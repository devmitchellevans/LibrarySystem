(function ($) {
    var form = $('#departmentCreateForm');
    var _departmentAppService = abp.services.app.department;

    function save() {
        if (!_$form.valid()) {
            return;
        }
    }

    _$form.find('.save-button').on('click', (e) => {
        e.preventDefault();

        if (!_$form.valid()) {
            return;
        }

        //var user = _$form.serializeFormToObject();
        //user.roleNames = [];
        //var _$roleCheckboxes = _$form[0].querySelectorAll("input[name='role']:checked");
        //if (_$roleCheckboxes) {

        //}

    })
})(jQuery);