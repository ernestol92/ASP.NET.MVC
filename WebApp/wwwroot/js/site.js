// dropdown 
document.addEventListener("DOMContentLoaded", function () {
    if (document.body.dataset.page !== "workspace") return;
    const dropdownButtons = document.querySelectorAll(".project-options-btn");
    const addProjectBtn = document.querySelector(".add-project");
    const modalBackground = document.querySelector(".modal");
    const modalAddProject = document.querySelector(".js-add-modal")
    const modalAddCloseBtn = document.querySelector(".close")

    const editProjectBtn = document.querySelector(".js-edit-btn")
    const modalEditProject = document.querySelector(".js-edit-modal")
    const modalEditCloseBtn = document.querySelector(".close-edit")


    //dropdown toggle
    dropdownButtons.forEach(button => {
        button.addEventListener("click", function (e) {
            e.stopPropagation();

            const dropdown = this.nextElementSibling;
            document.querySelectorAll(".drop-down").forEach(d => {
                if (d !== dropdown) {
                    d.classList.add("hidden");
                }
            });

            dropdown.classList.toggle("hidden");
        });
    });

    document.addEventListener("click", () => {
        document.querySelectorAll(".drop-down").forEach(dropdown => {
            dropdown.classList.add("hidden");
        });
    });

    // modalbackground + add project

    addProjectBtn.addEventListener("click", (e) => {
        e.stopPropagation();
        modalBackground.classList.add("modal-background-flex");
        modalAddProject.classList.add("modal-add-display");

    });

    modalAddCloseBtn.addEventListener("click", () => {
        modalBackground.classList.remove("modal-background-flex");
        modalAddProject.classList.remove("modal-add-display");
    });

     /*modalbackground + edit project*/

    editProjectBtn.addEventListener("click", (e) => {
        e.stopPropagation();
        modalBackground.classList.add("modal-background-flex");
        modalEditProject.classList.add("modal-edit-display");

    });

    modalEditCloseBtn.addEventListener("click", () => {
        modalBackground.classList.remove("modal-background-flex");
        modalEditProject.classList.remove("modal-edit-display");
    });

    // outside click exit modal

    document.addEventListener("click", (e) => {

        if (
            !modalAddProject.contains(e.target) &&
            !modalEditProject.contains(e.target)
        ) {
            modalBackground.classList.remove("modal-background-flex");
            modalAddProject.classList.remove("modal-add-display");
            modalEditProject.classList.remove("modal-edit-display");
        }
    });

    // submit form button



    // QUILL AND HIDDEN INPUT -- QUILL AND HIDDEN INPUT -- QUILL AND HIDDEN INPUT -- QUILL AND HIDDEN INPUT



    var quillAdd = new Quill("#editor-add", {
        theme: 'snow',
        placeholder: 'Write the project description here...',
        modules: { toolbar: '#toolbar' }

    })

    var quillEdit = new Quill("#editor-edit", {
        theme: 'snow',
        placeholder: 'Write the project description here...',
        modules: { toolbar: '#toolbar-edit' }

    })

    var addForm = document.querySelector("#add-form");
    addForm.addEventListener("submit", function (e) {
        var hiddenInputAdd = document.querySelector("#hidden-input-add");
        hiddenInputAdd.value = quillAdd.root.innerHTML;

        if (!addForm.checkValidity()) {
            e.preventDefault();
            e.stopPropagation();
            return;
        }
        console.log("hidden input value:", hiddenInputAdd.value);

    });

    var editForm = document.querySelector("#edit-form");
    editForm.addEventListener("submit", function (e) {
        var hiddenInputEdit = document.querySelector("#hidden-input-edit");
        hiddenInputEdit.value = quillEdit.root.innerHTML;

        if (!editForm.checkValidity()) {
            e.preventDefault();
            e.stopPropagation();
            showCustomValidationMessages();
            return;
        }
        console.log("hidden input value:", hiddenInputEdit.value);
        console.log("did not enter if")
    });
    
});



