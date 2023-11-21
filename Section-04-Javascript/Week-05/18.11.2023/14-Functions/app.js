"use strict";
// function selamVer() {
//     console.log("Merhaba");
// }


// selamVer();


// function selamVer2(message) {
//     console.log(message);
// }

// selamVer2("Merhaba, nasılsın? Bugün hava yağışlı.");


// function today() {
//     let result = new Date();
//     return result;
// }

// let bugun = today();
// console.log(bugun);


// function calculateAge(yearOfBirth) {
//     // let today = new Date();
//     // let year = today.getFullYear();
//     // let result = year - yearOfBirth;
//     // return result;
//     return new Date().getFullYear() - yearOfBirth;
// }

// console.log(calculateAge(1975));

/*
    Kadınlar için emeklilik yaşı 60
    Erkekler için emeklilik yaşı 65'tir.
    Buna göre Doğum Yılı, Cinsiyeti ve Adı verilen bir kişinin emekli olmasına kaç yıl kaldığını şu örnekteki gibi bildiren function'ı hazırlayınız:
    Sayın 'Fettah Can', emekli olmanıza 7 yıl kalmıştır.
*/

// function calculateAge(yearOfBirth) {
//     let today = new Date();
//     let year = today.getFullYear();
//     let result = year - yearOfBirth;
//     return result;
// }

// function calculatePension(yearOfBirth, gender, fullName) {
//     let age = calculateAge(yearOfBirth);
//     let diff = gender == "Kadın" ? 60 - age : 65 - age;
//     // let result = "Sayın '" + fullName + "' emekli olmanıza " + diff + " yıl kalmıştır.";
//     // let result = 'Sayın "' + fullName + '" emekli olmanıza ' + diff + ' yıl kalmıştır.';
//     // let result = 'Sayın \'' + fullName + '\' emekli olmanıza ' + diff + ' yıl kalmıştır.';
//     let result = `Sayın '${fullName}' emekli olmanıza ${diff} yıl kalmıştır.`;
//     return result;
// }

// console.log(calculatePension(1995, "Kadın", "Sezen Aksu"));
// console.log(calculatePension(1975, "Erkek", "Engin Niyazi Ergül"));

// Kendisine verilen bir dörtgenin kenar uzunluklarını alıp ilgili dörtgenin alanını ve çevresini hesaplayıp geri döndüren bir function hazırlayalım.

// function calculate(short, long) {
//     let area = short * long;
//     let env = (short + long) * 2;
//     // let result = [area, env];
//     let result = { area, env };
//     return result;
// }

// console.log(calculate(4, 6));


// SORU: Çalıştırıldığında bize "Yazı" ya da "Tura" şeklinde bir sonuç veren fonksiyonu hazırlayınız.

// function yaziTuraAt() {
//     let random = Math.random();
//     let result = random >= 0.5 ? "Yazı" : "Tura";
//     return result;
// }

// console.log(yaziTuraAt());

// SORU: Kendisine gönderilen sayının 'TAM BÖLENLERİNİ' bulup döndüren fonksionu hazırlayınız.

// function tamBolenler(sayi) {
//     let tamBolenlerDizisi = [];
//     for (let i = 1; i <= sayi; i++) {
//         // if (sayi % i == 0) {
//         //     tamBolenlerDizisi.push(i);
//         // }
//         if (sayi % i == 0) tamBolenlerDizisi.push(i);
//     }
//     return tamBolenlerDizisi;
// }

// console.log(tamBolenler(7));

// ÖDEV: 1-50 arasındaki asal sayıları bulup döndüren fonksiyonu yazınız.


// OBJECTS ödevi çözümü:

// let names = ["Ahmet", "Mehmet", "Yeşim"];
// let departments = ['İnşaat', 'Yazılım', 'Mimarlık'];
// let result = [];
// let random = 3;
// for (let i = 0; i < names.length; i++) {
//     while (random > 2) {
//         random = parseInt(Math.random() * 10);
//     }
//     result.push({ name: names[i], department: departments[random] });
//     random = 3;
// }
// console.log(result);

// let random = Math.random();
// console.log(random);
// console.log(random * 5);
// console.log(Math.floor(random));

// 3-10 arasında rasgele sayı üretmek
// let random = Math.floor(Math.random() * 7 + 3);


// Verilen min ve max değer arasında rastgele bir sayı üretir. min ve max dahildir.
function randomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1) + min);
}

console.log(randomInt(10, 15));

