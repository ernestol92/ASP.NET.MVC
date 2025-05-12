document.addEventListener("DOMContentLoaded", () => {
    const dropdownButtons = document.querySelectorAll(".project-options-btn");
    const addProjectBtn = document.querySelector(".add-project");
    const modalBackground = document.querySelector(".modal");
    const modalAddProject = document.querySelector(".js-add-modal");
    const modalAddCloseBtn = document.querySelector(".close");
    const editProjectBtn = document.querySelector(".js-edit-btn");
    const modalEditProject = document.querySelector(".js-edit-modal");
    const modalEditCloseBtn = document.querySelector(".close-edit");

    // Dropdown toggle
    dropdownButtons.forEach(button => {
        button.addEventListener("click", (e) => {
            e.stopPropagation();
            const dropdown = button.nextElementSibling;
            document.querySelectorAll(".drop-down").forEach(d => {
                if (d !== dropdown) d.classList.add("hidden");
            });
            dropdown.classList.toggle("hidden");
        });
    });

    document.addEventListener("click", () => {
        document.querySelectorAll(".drop-down").forEach(dropdown => dropdown.classList.add("hidden"));
    });

    // Add Project modal
    addProjectBtn?.addEventListener("click", (e) => {
        e.stopPropagation();
        modalBackground.classList.add("modal-background-flex");
        modalAddProject.classList.add("modal-add-display");
    });

    modalAddCloseBtn?.addEventListener("click", () => {
        modalBackground.classList.remove("modal-background-flex");
        modalAddProject.classList.remove("modal-add-display");
    });

    // Edit Project modal
    editProjectBtn?.addEventListener("click", (e) => {
        e.stopPropagation();
        modalBackground.classList.add("modal-background-flex");
        modalEditProject.classList.add("modal-edit-display");
    });

    modalEditCloseBtn?.addEventListener("click", () => {
        modalBackground.classList.remove("modal-background-flex");
        modalEditProject.classList.remove("modal-edit-display");
    });

    // Outside click closes modals
    document.addEventListener("click", (e) => {
        if (!modalAddProject.contains(e.target) && !modalEditProject.contains(e.target)) {
            modalBackground.classList.remove("modal-background-flex");
            modalAddProject.classList.remove("modal-add-display");
            modalEditProject.classList.remove("modal-edit-display");
        }
    });
});
