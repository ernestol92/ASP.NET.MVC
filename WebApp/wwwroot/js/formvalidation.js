document.addEventListener("DOMContentLoaded", () => {
    const forms = document.querySelectorAll("form");
    if (!forms) return;

    forms.forEach(form => {
        const fields = form.querySelectorAll("input[data-val='true']");
        fields.forEach(field => {
            field.addEventListener("input", () => validateField(field));
        });
    });

    function validateField(field) {
        const errorSpan = document.querySelector(`span[data-valmsg-for='${field.name}']`);
        if (!errorSpan) return;

        const value = field.value.trim();
        let errorMessage = "";

        if (field.hasAttribute("data-val-required") && value === "") {
            errorMessage = field.getAttribute("data-val-required");
        }

        errorSpan.classList.toggle("field-validation-error", !!errorMessage);
        errorSpan.classList.toggle("field-validation-valid", !errorMessage);
        errorSpan.textContent = errorMessage;
    }
});
