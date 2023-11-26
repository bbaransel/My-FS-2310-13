"use strict"
// Javascriptte class isimleri Pascal Case ile isimlendirilir.


// function Student() {
//     firstName = "";
//     lastName = "";
//     age = 0;
// };
// let student1 = new Student();
// student1.firstName = "Çağdaş"
// student1.lastName = "Taş"
// student1.age = 23;

function Product(productName, productPrice) {
    this.productName = productName;
    this.productPrice = productPrice;
};

// bu p1, p2, p3ler type ı Product türü adress tipli.

let p1 = new Product("IPhone 13", 42500);
console.log(p1)
let p2 = new Product("Samsung SE 22", 37000);
let p3 = p1;
console.log(p3);