document.addEventListener("DOMContentLoaded", () => {
    const quillAdd = new Quill("#editor-add", {
        theme: "snow",
        placeholder: "Write the project description here...",
        modules: { toolbar: "#toolbar" }
    });

    const quillEdit = new Quill("#editor-edit", {
        theme: "snow",
        placeholder: "Write the project description here...",
        modules: { toolbar: "#toolbar-edit" }
    });

    const addForm = document.querySelector("#add-form");
    const editForm = document.querySelector("#edit-form");

    addForm?.addEventListener("submit", function (e) {
        const hiddenInputAdd = document.querySelector("#hidden-input-add");
        hiddenInputAdd.value = quillAdd.root.innerHTML;

        if (!addForm.checkValidity()) {
            e.preventDefault();
            e.stopPropagation();
            return;
        }
        console.log("hidden input value:", hiddenInputAdd.value);
    });

    editForm?.addEventListener("submit", function (e) {
        const hiddenInputEdit = document.querySelector("#hidden-input-edit");
        hiddenInputEdit.value = quillEdit.root.innerHTML;

        if (!editForm.checkValidity()) {
            e.preventDefault();
            e.stopPropagation();
            if (typeof showCustomValidationMessages === "function") {
                showCustomValidationMessages();
            }
            return;
        }
        console.log("hidden input value:", hiddenInputEdit.value);
    });
});
