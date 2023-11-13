// let a = 5;
// if (a > 10) {
//     console.log("Sayı büyük.");
// };

// let a = 15;
// if (a > 10) {
//     console.log("Sayı büyük.");
// } else {
//     console.log("Sayı büyük değil.");
// };

// let a = 15;
// if (a > 10) {
//     console.log("Sayı büyük.");
// } else if (a < 10) {
//     console.log("Sayı küçük.");
// } else {
//     console.log("Sayılar eşit");
// };
// let a = 15;

// if (a > 10) {
//     console.log("Büyük");
// };

// if (a < 10) {
//     console.log("Küçük");
// };

// if (a == 10) {
//     console.log("Eşit");
// };


/*
    0-16: Çocuk
    17-35: Genç
    36-50: Yaşlı
    51-70: Ölmüş ağlayanı yok
    71'den büyükse: No comment
*/

// let age = 12;
// if (age <= 16) {
//     console.log("Çocuk");
// } else if (age <= 35) {
//     console.log("Genç");
// } else if (age <= 50) {
//     console.log("Yaşlı");
// } else if (age <= 70) {
//     console.log("Ölmüş, ağlayanı yok");
// } else {
//     console.log("No comment");
// };

// if (age <= 16) {
//     console.log("Çocuk");
// };
// if (age <= 35) {
//     console.log("Genç");
// };
// if (age <= 50) {
//     console.log("Yaşlı");
// }
// if (age <= 70) {
//     console.log("Ölmüş, ağlayanı yok");
// } 
// if (age>70){
//     console.log("No comment");
// };


// Ternary if oparetor (Üçlü operatör)
// let message;
// let age = 10;
// if (age >= 18) {
//     message = "girebilirsiniz.";
// } else {
//     message = "giremezsiniz.";
// };

// message = age >= 18 ? "girebilirsiniz." : "giremezsiniz.";
// console.log("Yaşınız " + age + " olduğu için " + message);


/*
    0-16: Çocuk
    17-35: Genç
    36-50: Yaşlı
    51-70: Ölmüş ağlayanı yok
    71'den büyükse: No comment
*/
//Ternary if çözümü

// let age = 80;
// let result;
// result =
//     age <= 16 ? "Çocuk" :
//         age <= 35 ? "Genç" :
//             age <= 50 ? "Yaşlı" :
//                 age <= 70 ? "Ölmüş ağlayanı yok" : "No comment";
// console.log(result);

// alert("Merhaba");
// let message = "Merhaba";
// alert(message);

// let age;
// age = prompt("Kaç yaşındasınız?");
// console.log(age + " yaşındasınız.");
// console.log(typeof age);


// result = confirm("Emin misiniz?");

/* 
SORU-1)

let a=40;
let b=60;
let result;
if(a-b < 30){
    result = "Küçük";
}else{
    result = "Büyük"
};

Yukarıdaki kodu Ternary if kullanarak yazın.

CEVAP:
let a = 40;
let b = 60;
let result = a - b < 30 ? "küçük" : "büyük";
console.log(result);
*/

/*
Kullanıcıya "JavaScript'in official ismi nedir?" şeklinde bir soru sorup, gelen cevap "ECMAScript" ise "Tebrikler, bildiniz!", değil ise "Yanlış cevap! Yeniden deneyiniz!" şeklinde bir cevabı alert ile veren kodu;
a) if..else ile
b) ternary if ile yazınız.
*/

let correctAnswer = "ECMAScript";
let userAnswer = prompt("Javascript'in official ismi nedir?");
let result;
//a) 
// if (userAnswer == correctAnswer) {
//     result = "Tebrikler, bildiniz!";
// } else {
//     result = "Yanlış cevap, yeniden deneyiniz!";
// };

//b)
result = userAnswer == correctAnswer ? "Tebrikler, bildiniz" : "Yanlış cevap, yeniden deneyiniz!";

alert(result);
















