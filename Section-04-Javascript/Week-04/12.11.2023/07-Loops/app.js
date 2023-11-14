// Döngü: Aynı kod parçasının tekrar tekrar çalıştırılmasını sağlayan yapıya döngü denir.

//WHILE
// let a = 1;
// while (a <= 10) {
//     console.log(a);
//     a++;
// };

// 1-10 arasındaki çift sayıları konsola yazdırın.
// let i = 1;
// while (i <= 10) {
//     if (i % 2 == 0) {
//         console.log(i);
//     }
//     i++;
// };

// SORU:
// 1-50 arasındaki 4'ün katı olan sayıların adedini bulup konsola yazdırın.
// let i = 1;
// let toplam = 0;
// while (i <= 50) {
//     if (i % 4 == 0) {
//         toplam++
//     }
//     i++
// }
// console.log("1 ile 50 arasında 4'ün katı olan " + toplam + " adet sayı vardır.");

// Girilecek 3 adet sayıyı toplayıp konsola yazdıralım

// let i = 1;
// let num;
// let total = 0;
// while (i <= 3) {
//     num = Number(prompt("Lütfen sayıyı giriniz."));
//     // total=total+num;
//     total += num;
//     i++;
// };
// console.log(total)


// kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınız. Kullanıcı 0 girerse uygulama sona ersin.
// let i = 1;
// let num;
// let total = 0;
// while (true) {
//     num = Number(prompt("Lütfen bir sayı giriniz."));
//     if (num == 0) {
//         break;
//     }
//     total += num;

// };
// console.log("Girlilen sayıların toplamı " + total);

// kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınız. Kullanıcı Exit yazarsa uygulama sona ersin.

// let i = 1;
// let num;
// let total = 0;
// while (true) {
//     num = prompt("Lütfen " + i + ". sayıyı giriniz.");
//     if (num.toLocaleLowerCase() == "exit") {
//         break;
//     }
//     total += Number(num);
//     i++;
// };
// console.log("Girdiğiziz " + --i + " adet sayının toplamı " + total);


// FOR

// let count = Number(prompt("Lütfen bir sayı gir."))
// for (let i = 0; i <= count; i++) {
//     console.log(i)
// }

// 1 ile 10 arasındaki çift sayıları konsola yazdır.
// for (let i = 0; i < 10; i++) {
//     if (i % 2 == 0) {
//         console.log(i)
//     }
// }
// for (let i = 0; i < 10; i++) {
//     if (i % 2 == 0) continue;
//     console.log(i)

// }

// kullanıcının istediği kadar sayı girmesine izin veren ve girilen sayıları toplayıp konsola yazan kodu yazınız. Kullanıcı Exit yazarsa uygulama sona ersin. NOT: for ile yap

// let total = 0;
// let num;
// for (let i = 0; i == 0;) {
//     num = prompt("Lütfen bir sayı giriniz.");
//     if (num.toLocaleLowerCase() == "exit") {
//         break;
//     }
//     total += Number(num);
// }
// console.log(total);

// 1-20 arası sayıları konsola şu şekilde yazdıran kod

// 1) Tek sayı
// 2) Çift sayı
// 3) Tek Sayı
// 4) Çift Sayı
//...

// for (let i = 0; i <= 20; i++) {
//     if (i % 2 == 0) {
//         console.log(i + " Çift Sayı")
//     }
//     else {
//         console.log(i + " Tek Sayı")
//     }
// }

