/*
    DOM-Document Object Model
*/

// 1) Single Element

// let result; 
// getElementById

// result = document.getElementById("task-list");
// result = document.getElementById("title");
// result.style.backgroundColor = "red";
// result.style.color = "white";
// result.style.padding = "10px";
// // result.innerText = "Full Stack Programlama";
// result.innerHTML="<span style='color:yellow'>Full Stack</span> Programlama";

// querySelector

// Not: querySelector, dokümanın en üstünden başlayarak ilk karşılaştığı elemanı bulup getirir.
// result = document.querySelector("#title");
// result = document.querySelector(".card-title");
// result = document.querySelector("li");
// console.log(result);

// 2) Multi Elements

// getElementsByClassName

// let result;
// result = document.getElementsByClassName("card-title");
// result = document.querySelector("li"); //Birazdan tümünü seçecek querySelectorAll'ı öğreneceğiz.
// result = document.getElementsByClassName("task");

// getElementsByTagName
// result = document.getElementsByTagName("li");

// querySelectorAll
// result = document.querySelectorAll(".task");
// result = document.querySelectorAll("#task-list-2 .task");
// console.log(result);

// Araştırma Ödevi: HTMLCollection ile NodeList arasındaki fark ve benzerlikleri araştırın.


// 3) Traversing Elements

let result;
// let taskList = document.getElementById("task-list");
// result = taskList.children;
// console.log(taskList);

// let body = document.querySelector("body");
// console.log(body);
// result = body.children;
// result = body.children[3];
// result = body.firstElementChild;
// result = body.lastElementChild;

// result = document.getElementById("title");
// result = result.parentElement.parentElement.parentElement.parentElement;

result = document.getElementById("task-list");
result = result.firstElementChild;
result = result.nextElementSibling.nextElementSibling;
result = result.previousElementSibling.previousElementSibling.previousElementSibling;
console.log(result);