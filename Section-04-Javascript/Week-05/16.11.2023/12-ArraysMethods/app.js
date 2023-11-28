"use strict";

let students = ["ayşen", "umay", "ceyda", "begüm", "köfte", "heda"];

let result;

result = students.length;
result = students;
result = students.toString();
result = students.join(";");
result = result.split(";");
let products1 = ["ürün1", "ürün2", "ürün3"];
let products2 = ["ürün4", "ürün5", "ürün6"];
result = products1.concat(products2);

// students.push("zeynep"); // Sona eleman ekler.
// students.pop(); // Son elemanı siler.
// students.shift(); // İlk elemanı siler.
// students.unshift("ece"); // Dizinin başına eleman ekler.

// students dizisindeki ceyda değerini taşıyan elemanın içeriğini ece olarak değiştir.

students[students.indexOf("ceyda")] = "ece";
students.splice(students.indexOf("ceyda"), 1)
// result = students.splice(2,3);

result = students;



console.log(result);