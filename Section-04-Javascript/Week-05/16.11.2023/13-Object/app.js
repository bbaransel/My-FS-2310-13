// JavaScript Object Notation - JSON
"use strict"

// let student1 = ["Zeynep Nur", "Ay", 28, "Kadın",];
// let student2 = ["Çağdaş", "Taş", 28, "Erkek"];
// let student3 = ["Furkan", "Gültekin", 20, "Erkek"];

// let students = [student1, student2, student3];
// console.log(students);

// for (let i = 0; i < students.length; i++) {
//     console.log(students[i][0] + " " + students[i][2]);
// };

// Yukarıdaki student1 değişkeni bir objectir. firstName, lastName, age, gender bu objectin özellikleridir.(property)

// console.log(student1.firstName);
// console.log(student1.gender + " " + student1.age);

let student1 = {
    firstName: "Zeynep Nur",
    lastName: "Ay",
    age: 28,
    gender: "Kadın"
};
let student2 = {
    firstName: "Mehmet Emir",
    lastName: "Sürmeli",
    age: 21,
    gender: "Erkek"
};
let student3 = {
    firstName: "Didier",
    lastName: "Drogba",
    age: 45,
    gender: "Erkek"
};

// let students = [student1, student2, student3];
// let total = 0;
// for (let i = 0; i < students.length; i++) {
//     console.log(students[i].firstName + " " + students[i].gender);
//     total += students[i].age;
// }
// console.log("Bu sınıfın yaş ortalaması: " + (total / students.length));

let students = [student1, student2, student3];
let total = 0;
let studentsCount = students.length;
for (let i = 0; i < studentsCount; i++) {
    console.log(students[i].firstName + " " + students[i].gender);
    total += students[i].age;
}
let average = total / studentsCount;
console.log("Bu sınıfın yaş ortalaması: " + average.toFixed(2));

/* İçerisinde Ahmet Mehmet ve Yeşim değerlerinin olduğu bir dizi tanımlayın. Ayrıca içerisinde inşaat müh. Yazılım müh. ve Mimarlık değerlerinin olduğu bir başka dizi daha tanımlayın. Sonra içinde name ve department bilgilerinin yer aldığı 3 adet student objesini şu şekilde oluşturun:
Üç öğrenciye rastgele bölüm atansın ve örnek olarak şu şekilde nesneler oluşsun:
{
    name:"Ahmet",
    department: "Yazılım Müh"
}
*/