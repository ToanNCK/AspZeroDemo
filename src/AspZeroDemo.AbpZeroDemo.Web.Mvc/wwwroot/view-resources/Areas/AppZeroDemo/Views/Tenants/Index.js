﻿(function () {
    $(function () {

        var _tenantService = abp.services.app.tenant;
        var _$tenantsTable = $("#TenantsTable");
        //var $('#TenantsTableFilter') = $('#TenantsTableFilter');
        var _$tenantsFormFilter = $('#TenantsFormFilter');
        var _$tenantsFormFilterBtn = $('#TenantsFormFilterBtn');
        var _$subscriptionEndDateRangeActive = $("#TenantsTable_SubscriptionEndDateRangeActive");
        var _$subscriptionEndDateRange = _$tenantsFormFilter.find("input[name='SubscriptionEndDateRange']");
        var _$creationDateRangeActive = $("#TenantsTable_CreationDateRangeActive");
        var _$creationDateRange = _$tenantsFormFilter.find("input[name='CreationDateRange']");
        var _$refreshButton = _$tenantsFormFilterBtn.find("button[name='RefreshButton']");
        var _$editionDropdown = _$tenantsFormFilter.find("#EditionDropdown");
        var _entityTypeFullName = 'AspZeroDemo.AbpZeroDemo.MultiTenancy.Tenant';
        var _$removeFinlterAllButton = _$tenantsFormFilterBtn.find("button[name='RemoveLocAll']");

        var _permissions = {
            create: abp.auth.hasPermission('Pages.Tenants.Create'),
            edit: abp.auth.hasPermission('Pages.Tenants.Edit'),
            changeFeatures: abp.auth.hasPermission('Pages.Tenants.ChangeFeatures'),
            impersonation: abp.auth.hasPermission('Pages.Tenants.Impersonation'),
            'delete': abp.auth.hasPermission('Pages.Tenants.Delete')
        };

        var _urlParams = {
            creationDateStart: $.url('?creationDateStart'),
            creationDateEnd: $.url('?creationDateEnd'),
            subscriptionEndDateStart: $.url('?subscriptionEndDateStart'),
            subscriptionEndDateEnd: $.url('?subscriptionEndDateEnd')
        };

        var _selectedSubscriptionEndDateRange = {
            startDate: _urlParams.subscriptionEndDateStart ? moment(_urlParams.subscriptionEndDateStart) : moment().startOf('day'),
            endDate: _urlParams.subscriptionEndDateEnd ? moment(_urlParams.subscriptionEndDateEnd) : moment().add(30, 'days').endOf('day')
        };

        var _selectedCreationDateRange = {
            startDate: _urlParams.creationDateStart ? moment(_urlParams.creationDateStart) : moment().add(-7, 'days').startOf('day'),
            endDate: _urlParams.creationDateEnd ? moment(_urlParams.creationDateEnd) : moment().endOf('day')
        };

        _$subscriptionEndDateRange.daterangepicker(
            $.extend(true, app.createDateRangePickerOptions({
                allowFutureDate: true
            }), _selectedSubscriptionEndDateRange),
            function (start, end, label) {
                _selectedSubscriptionEndDateRange.startDate = start;
                _selectedSubscriptionEndDateRange.endDate = end;
            });

        _$creationDateRange.daterangepicker(
            $.extend(true, app.createDateRangePickerOptions(), _selectedCreationDateRange),
            function (start, end, label) {
                _selectedCreationDateRange.startDate = start;
                _selectedCreationDateRange.endDate = end;
            });

        var _createModal = new app.ModalManager({
            viewUrl: abp.appPath + "AppZeroDemo/Tenants/CreateModal",
            scriptUrl: abp.appPath + "view-resources/Areas/AppZeroDemo/Views/Tenants/_CreateModal.js",
            modalClass: "CreateTenantModal"
        });

        var _editModal = new app.ModalManager({
            viewUrl: abp.appPath + "AppZeroDemo/Tenants/EditModal",
            scriptUrl: abp.appPath + "view-resources/Areas/AppZeroDemo/Views/Tenants/_EditModal.js",
            modalClass: "EditTenantModal"
        });

        var _featuresModal = new app.ModalManager({
            viewUrl: abp.appPath + "AppZeroDemo/Tenants/FeaturesModal",
            scriptUrl: abp.appPath + "view-resources/Areas/AppZeroDemo/Views/Tenants/_FeaturesModal.js",
            modalClass: "TenantFeaturesModal"
        });

        var _userLookupModal = app.modals.LookupModal.create({
            title: app.localize("SelectAUser"),
            serviceMethod: abp.services.app.commonLookup.findUsers
        });

        var _entityTypeHistoryModal = app.modals.EntityTypeHistoryModal.create();

        var getFilter = function () {
            var editionId = _$editionDropdown.find(":selected").val();

            var filter = {
                filter: $('#TenantsTableFilter').val(),
                editionId: editionId,
                editionIdSpecified: editionId !== "-1"
            };

            if (_$creationDateRangeActive.prop("checked")) {
                filter.creationDateStart = _selectedCreationDateRange.startDate;
                filter.creationDateEnd = _selectedCreationDateRange.endDate;
            }

            if (_$subscriptionEndDateRangeActive.prop("checked")) {
                filter.subscriptionEndDateStart = _selectedSubscriptionEndDateRange.startDate;
                filter.subscriptionEndDateEnd = _selectedSubscriptionEndDateRange.endDate;
            }

            return filter;
        };

        function entityHistoryIsEnabled() {
            return abp.custom.EntityHistory &&
                abp.custom.EntityHistory.IsEnabled &&
                _.filter(abp.custom.EntityHistory.EnabledEntities, function (entityType) {
                    return entityType === _entityTypeFullName;
                }).length === 1;
        }

        var dataTable = _$tenantsTable.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            orderCellsTop: true,
            fixedHeader: true,
            listAction: {
                ajaxFunction: _tenantService.getTenants,
                inputFilter: function () {
                    return getFilter();
                }
            },
            columnDefs: [
                {
                    className: 'control responsive',
                    orderable: false,
                    render: function () {
                        return '';
                    },
                    targets: 0
                },
                {
                    targets: 1,
                    data: null,
                    orderable: false,
                    autoWidth: false,
                    defaultContent: '',
                    rowAction: {
                        text: '<i class="fa fa-cog"></i> ' + app.localize('Actions') + ' <span class="caret"></span>',
                        items: [
                            {
                                text: app.localize('LoginAsThisTenant'),
                                visible: function () {
                                    return _permissions.impersonation;
                                },
                                action: function (data) {
                                    _userLookupModal.open({
                                        extraFilters: {
                                            tenantId: data.record.id
                                        },
                                        title: app.localize('SelectAUser')
                                    },
                                        function (selectedItem) {
                                            abp.ajax({
                                                url: abp.appPath + 'Account/Impersonate',
                                                data: JSON.stringify({
                                                    tenantId: data.record.id,
                                                    userId: parseInt(selectedItem.value)
                                                }),
                                                success: function () {
                                                    if (!app.supportsTenancyNameInUrl) {
                                                        abp.multiTenancy.setTenantIdCookie(data.record.id);
                                                    }
                                                }
                                            });
                                        });
                                }
                            },
                            {
                                text: app.localize('Edit'),
                                visible: function () {
                                    return _permissions.edit;
                                },
                                action: function (data) {
                                    _editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: app.localize('Features'),
                                visible: function () {
                                    return _permissions.changeFeatures;
                                },
                                action: function (data) {
                                    _featuresModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: app.localize('Delete'),
                                visible: function () {
                                    return _permissions.delete;
                                },
                                action: function (data) {
                                    deleteTenant(data.record);
                                }
                            },
                            {
                                text: app.localize('Unlock'),
                                action: function (data) {
                                    _tenantService.unlockTenantAdmin({
                                        id: data.record.id
                                    }).done(function () {
                                        abp.notify.success(app.localize('UnlockedTenandAdmin', data.record.name));
                                    });
                                }
                            },
                            {
                                text: app.localize('History'),
                                visible: function () {
                                    return entityHistoryIsEnabled();
                                },
                                action: function (data) {
                                    _entityTypeHistoryModal.open({
                                        entityTypeFullName: _entityTypeFullName,
                                        entityId: data.record.id,
                                        entityTypeDescription: data.record.name
                                    });
                                }
                            }
                        ]
                    }
                },
                {
                    targets: 2,
                    data: "tenancyName"
                },
                {
                    targets: 3,
                    data: "name"
                },
                {
                    targets: 4,
                    data: "editionDisplayName"
                },
                {
                    targets: 5,
                    data: "subscriptionEndDateUtc",
                    render: function (subscriptionEndDateUtc) {
                        if (subscriptionEndDateUtc) {
                            return moment(subscriptionEndDateUtc).format('L');
                        }

                        return "";
                    }
                },
                {
                    targets: 6,
                    data: "isActive",
                    render: function (isActive) {
                        if (isActive) {
                            return '<span class="label label-success label-inline">' + app.localize('Yes') + '</span>';
                        } else {
                            return '<span class="label label-dark label-inline">' + app.localize('No') + '</span>';
                        }
                    }
                },
                {
                    targets: 7,
                    data: "creationTime",
                    render: function (creationTime) {
                        return moment(creationTime).format('L');
                    }
                }
            ],
            initComplete: function () {
                $('#TenantsTable thead tr:eq(1) th').each(function (i) {
                    if (i === 0) {
                        $(this).css('display', 'none');
                    }

                    $('input,select', this).on('change', function () {
	                    setLblFileter();
                        dataTable.draw();
                    });
                });

                $(document).on('click', '#lbl-loc .remove-lbl-loc', function () {
	                var isParent = $(this).parent('.display-flex');
                    var id = '#' + isParent.data('loc');
                    isParent.remove();
	                $(id).val('');
	                if ($(id).hasClass('edited')) {
		                $(id).val('-1');
	                }

	                dataTable.draw();
                });
            }
        });

        function getQueryStringParameter(name) {
            var uri = URI.parseQuery(document.location.href);
            return uri[name];
        }

        function getTenants() {
            dataTable.ajax.reload();
        }

        function deleteTenant(tenant) {
            abp.message.confirm(
                app.localize("TenantDeleteWarningMessage", tenant.tenancyName),
                app.localize('AreYouSure'),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _tenantService.deleteTenant({
                            id: tenant.id
                        }).done(function () {
                            getTenants();
                            abp.notify.success(app.localize("SuccessfullyDeleted"));
                        });
                    }
                }
            );
        }

        $('#CreateNewTenantButton').click(function () {
            _createModal.open();
        });

        $('#GetTenantsButton').click(function (e) {
            e.preventDefault();
            getTenants();
        });

        abp.event.on("app.editTenantModalSaved",
            function () {
                getTenants(true);
            });

        abp.event.on("app.createTenantModalSaved",
            function () {
                getTenants(true);
            });

        _$subscriptionEndDateRangeActive.change(function () {
            _$subscriptionEndDateRange.prop("disabled", !$(this).prop("checked"));
        });

        if (_urlParams.subscriptionEndDateStart || _urlParams.subscriptionEndDateEnd) {
            _$subscriptionEndDateRangeActive.prop("checked", true);
        } else {
            _$subscriptionEndDateRange.prop("disabled", true);
        }

        _$creationDateRangeActive.change(function () {
            _$creationDateRange.prop("disabled", !$(this).prop("checked"));
        });

        if (_urlParams.creationDateStart || _urlParams.creationDateEnd) {
            _$creationDateRangeActive.prop("checked", true);
        } else {
            _$creationDateRange.prop("disabled", true);
        }

        _$refreshButton.click(function (e) {
            e.preventDefault();
            getTenants();
        });

        $('#TenantsTableFilter').focus();

        function setLblFileter() {
	        $('#lbl-loc').empty();
            $('#lbl-loc').append('<h5 class="text-dark font-weight-bold mt-2 mb-2 mr-5">Lọc:</h5>');
            $('#TenantsFormFilter th > input, #TenantsFormFilter th > select').each(function () {
                var textString = '';
                if (!$(this).hasClass('edited')) {
	                textString = $(this).val();
                } else {
                    textString = $('#' + $(this).attr('id') + ' option:selected').text();
                }
		        var html = '<div class="display-flex" data-loc="' + $(this).attr('id') + '"> ' +
                    '<h5 class="text-dark font-weight-bold mt-2 mb-2 lbl-loc-text ml-5">' + textString + '</h5> ' +
			        '<h5 class="font-weight-bold mt-2 mb-2 remove-lbl-loc">X</h5> ' +
			        '</div>';
                if (textString && $(this).attr('id')) {
			        $('#lbl-loc').append(html);
		        }
	        });
        }

        _$removeFinlterAllButton.click(function () {
            _$tenantsFormFilter.find('input, select').each(function () {
                if (!$(this).hasClass('edited')) {
                    $(this).val('');
                } else {
                    $(this).val('-1');
                }
            });

            dataTable.draw();
        });

    });
})();
