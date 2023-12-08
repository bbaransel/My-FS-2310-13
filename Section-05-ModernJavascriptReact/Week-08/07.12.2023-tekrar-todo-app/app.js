"use strict"
const task = document.querySelector('#task');
const taskList = document.querySelector("#task-list");
const filters = document.querySelectorAll('#filters span');

let isEditMode = false;
let editedTaskId;
let filterMode = "all";
let taskListArray = [];


const addTask = (e) => {
    e.preventDefault();
    let addedTaskValue = task.value.trim();
    if (addedTaskValue) {
        let id = taskListArray.length == 0 ? 1 : taskListArray[taskListArray.length - 1].id + 1;
        taskListArray.push({
            "id": id,
            "task": addedTaskValue,
            "status": "pending"
        });
        // buradan tüm görevleri yeniden listeleyecek fonksiyonu çağıracağız
        displayTasks(filterMode);
        // buradan da girilen yeni görev bilgisini içerecek şekilde elimizdeki task list array dizisinde yer alan tüm görevleri localestoragea aktaran fonksiyonu çağıracağız
        setToLocaleStorage();
    } else {
        alert("Please enter a task")
    }
    task.value = "";
    task.focus();

}

const updateTaskStatus = (element) => {
    const newStatus = element.checked ? "completed" : "pending";
    for (const taskItem of taskListArray) {
        if (element.id == taskItem.id) {
            taskItem.status = newStatus;
            break;
        };
    };
    setToLocaleStorage();
    displayTasks(filterMode);
}

const clearAll = () => {
    taskListArray = [];
    setToLocaleStorage();
    displayTasks(filterMode);
}
const deleteTask = (id) => {
    // let deletedTask = taskListArray.filter((taskItem) => {
    //     if (id == taskItem.id) return true
    // })
    // let index = taskListArray.indexOf(deletedTask[0]);
    // taskListArray.splice(index, 1);
    // setToLocaleStorage();
    // displayTasks(filterMode);
    for (let i = 0; i < taskListArray.length; i++) {
        if (id == taskListArray[i].id) {
            taskListArray.splice(i, 1);
            setToLocaleStorage()
            displayTasks(filterMode);
        }
    };
}

const displayTasks = (filterMode) => {
    taskList.innerHTML = "";
    if (taskListArray.length == 0) {
        taskList.innerHTML = `<div class='alert alert-warning text-danger'>${filterMode} görev Bulunamadı</div>`
    } else if (taskListArray.length == 0) {
        taskList.innerHTML = `<div class='alert alert-warning text-danger'>${filterMode} görev Bulunamadı</div>`
        return;
    } else {
        for (const taskItem of taskListArray) {
            if (filterMode == "all" || filterMode == taskItem.status) {
                let completed = taskItem.status == "completed" ? "text-decoration-line-through" : "";
                let taskLiElement = `
                <li class="list-group-item p-2" id="${taskItem.id}">
                    <div class="form-check form-switch d-flex justify-content-between align-items-center">
                        <input onclick="updateTaskStatus(this);" class="form-check-input" type="checkbox" role="switch" id="${taskItem.id}" ${taskItem.status == "completed" ? "checked" : ""}>
                        <div class="input-group">
                            <input type="text" class="form-control  ${completed}" value="${taskItem.task}" id="${taskItem.id}" disabled>
                            <button onclick="" class="btn btn-warning" id="${taskItem.id}"><i
                                    class="fa-solid fa-pen-to-square"></i></button>
                            <button onclick="deleteTask(${taskItem.id})" class="btn btn-danger" id="${taskItem.id}"><i class="fa-solid fa-trash"></i></button>
                        </div>
                    </div>
                </li>
                `;
                taskList.insertAdjacentHTML("beforeend", taskLiElement);
            }
        }
    }
}

const getFromLocaleStorage = () => {
    taskListArray = localStorage.getItem("task-list-fs-2310-13") === null ? [] : JSON.parse(localStorage.getItem("task-list-fs-2310-13"))
}
const setToLocaleStorage = () => {
    localStorage.setItem("task-list-fs-2310-13", JSON.stringify(taskListArray));
}

const assignSpanClickEvents = () => {
    for (const span of filters) {
        span.addEventListener("click", () => {
            let activeSpan = document.querySelector("#filters span.text-primary")
            activeSpan.className = "";
            span.classList.add("text-primary");
            span.classList.add("fw-bold");
            filterMode = span.id;
            displayTasks(filterMode);
        });
    }
}



getFromLocaleStorage();
displayTasks(filterMode);
assignSpanClickEvents();