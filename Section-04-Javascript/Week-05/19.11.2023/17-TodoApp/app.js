"use strict";
const txtTaskDescription = document.getElementById("txt-task-description");
const btnAddTask = document.getElementById("btn-add-task");
const taskList = document.getElementById("task-list");
const btnClearAll = document.getElementById("btn-clear-all");
const filters = document.querySelectorAll("#filters span");


let isEditMode = false; //Eğer bu değişken false ise Yeni Kayıt modundayız, true ise Düzenleme modundayız.
let editedTaskId; //O anda hangi görev düzenleniyor ise uygulama boyunca geçerli olacak şekilde o görevin id'sini tutmaya yarar.
let filterMode = "all";

let taskListArray = [];

//btnAddTask elementine click yapıldığında çalışacak fonksiyonun adı addTask'tir.
btnAddTask.addEventListener("click", addTask);

//btnClearAll elementine click yapıldığında çalışacak fonksiyonun adı clearAll'dur.
btnClearAll.addEventListener("click", clearAll);

//Yeni görev ekleyen fonksiyon
function addTask(event) {
    event.preventDefault();//ilgili olayın default davranışlarını iptal ediyor.
    let value = txtTaskDescription.value.trim();
    if (value != "") {
        let id = taskListArray.length == 0 ? 1 : taskListArray[taskListArray.length - 1].id + 1;
        taskListArray.push(
            {
                "id": id,
                "taskDescription": value,
                "status": "pending"
            }
        );
        displayTasks(filterMode);
        setTasks();
    } else {
        alert("Lütfen görev açıklamasını boş bırakmayınız.")
    }
    txtTaskDescription.value = "";
    txtTaskDescription.focus();
}

// Bu function, her ihtiyaç duyulduğunda tüm görevleri yeniden okuyup ekranda göstermek için kullanılacak.
function displayTasks(filter) {
    taskList.innerHTML = "";
    if (taskListArray.length == 0) {
        taskList.innerHTML = `<div class="alert alert-warning mb-0">Tanımlı görev bulunmamaktadır.</div>`;
    } else {
        for (const task of taskListArray) {
            if (filter == "all" || filter == task.status) {
                let completed = task.status == "completed" ? "checked" : "";
                let taskLi = `
                <li class="task list-group-item" id="${task.id}">
                    <div class="form-check d-flex justify-content-between align-items-center">
                        <input onclick="updateStatus(this);" type="checkbox" id="${task.id}" class="form-check-input" ${completed}>
                        <div class="input-group">
                            <input id="${task.id}" class="form-control ${completed}" type="text" value="${task.taskDescription}"
                                disabled />
                            <button onclick="editTask(this);" id="${task.id}" class="btn btn-warning"><i class="fa-solid fa-pen-to-square"></i></button>
                            <button onclick="deleteTask(this);" id="${task.id}" class="btn btn-danger"><i class="fa-solid fa-trash"></i></button>
                        </div>
                    </div>
                </li>
            `;
                taskList.insertAdjacentHTML("beforeend", taskLi);
            };
        };
    };
};

// Task update (tamamlandı/devam ediyor) işlemini yapan fonksiyon
function updateStatus(activeTask) {
    let newStatus = activeTask.checked ? "completed" : "pending";
    for (const task of taskListArray) {
        if (activeTask.id == task.id) {
            task.status = newStatus;
            break;
        }
    }
    setTasks();
    displayTasks(filterMode);
}

// İlgili görevin düzenlenmesini yapar
function editTask(clickedButton) {
    //Araştırma Ödevi: bir text'e odaklandığımızda içindeki metnin sonuna ya da seçili bir halde odaklanmanın bir yolu var mı? Varsa nasıl?
    editedTaskId = clickedButton.id;
    let editedTask = clickedButton.previousElementSibling;
    let checked;
    for (const task of taskListArray) {
        if (task.id == editedTaskId) {
            checked = task.status;
            break;
        };
    }
    if (!isEditMode) {
        editedTask.removeAttribute("disabled");
        if (checked == "completed") editedTask.classList.remove("checked");
        clickedButton.classList.remove("btn-warning");
        clickedButton.classList.add("btn-info");
        // clickedButton.firstElementChild.classList.remove("fa-pen-to-square");
        // clickedButton.firstElementChild.classList.remove("fa-solid");
        // clickedButton.firstElementChild.classList.add("fa-circle-check");
        // clickedButton.firstElementChild.classList.add("fa-regular");
        clickedButton.innerHTML = '<i class="fa-regular fa-circle-check"></i>';
        editedTask.focus();
        isEditMode = true;
    } else {
        editedTask.setAttribute("disabled", "disabled");
        if (checked == "completed") editedTask.classList.add("checked");
        clickedButton.classList.remove("btn-info");
        clickedButton.classList.add("btn-warning");
        clickedButton.innerHTML = '<i class="fa-solid fa-pen-to-square"></i>';
        for (const task of taskListArray) {
            if (editedTaskId == task.id) {
                task.taskDescription = editedTask.value;
                break;
            }
        }
        isEditMode = false;
        setTasks();
        displayTasks(filterMode);
    }

}

//İlgili görevi siler
function deleteTask(clickedButton) {
    let deletedTaskId = clickedButton.id;
    let deletedTask = taskListArray.filter(function (task) {
        if (deletedTaskId == task.id) return true;
    });
    let deletedTaskDescription = deletedTask[0].taskDescription;
    let answer = confirm(`'${deletedTaskDescription}' görevi silinecektir!`);
    if (answer) {
        let index = taskListArray.indexOf(deletedTask[0]);
        taskListArray.splice(index, 1);
        setTasks();
        displayTasks(filterMode);
        alert("Silme işlemi başarıyla tamamlanmıştır.");
    }
}

//Tüm görevleri siler
function clearAll() {
    let answer = confirm("Tüm görevler silinecektir!");
    if (answer) {
        // taskListArray = [];
        taskListArray.splice(0);
        setTasks();
        displayTasks(filterMode);
    }
}

// Filters içindeki spanlara click eventlerini atar.
function assignSpansEvents() {
    for (const span of filters) {
        span.addEventListener("click", function () {
            let activeSpan = document.querySelector("span.active");
            activeSpan.classList.remove("active");
            span.classList.add("active");
            filterMode = span.id;
            displayTasks(filterMode);
        });
    };
};

document.getElementById("all").addEventListener("click",function(){

});
document.getElementById("completed").addEventListener("click", function () {

});
document.getElementById("pending").addEventListener("click", function () {

});

// LocalStorage'deki datamızı okuyup dizimizin içine aktaracak.
function getTasks() {
    // Task'lerimiz LocalStorage'de TaskList adında bir key'in içinde tutulacak.
    let TaskListItem = localStorage.getItem("TaskList");

    if (TaskListItem != null) {
        taskListArray = JSON.parse(TaskListItem);
    };
};

function setTasks() {
    localStorage.setItem("TaskList", JSON.stringify(taskListArray));
    console.log(JSON.stringify(taskListArray), typeof JSON.stringify(taskListArray));
};

getTasks();
assignSpansEvents();
displayTasks(filterMode);

// ARAŞTIRMA ÖDEVİ: Görev adına tıkladığımızda da completed ya da pending şeklinde status değişimi olmasını nasıl sağlarız?
