let result;
let now;
now = new Date();
result = now

result = now.getDate(); // kaçıncı gün olduğu bilgisini verir.
result = now.getDay(); // Haftanın kaçıncı günü olduğunu.

// let newDate = new Date(2023, 5, 18); // Aylar saçma bir şekilde 0'dan başlıyor. 
// console.log(newDate);
// result = newDate.getDay()

result = now.getFullYear()
result = now.getHours();
result = now.getTime();
// result = result.getTime();
result = new Date(1900, 0, 1, 10, 30, 0);
let year = result.getFullYear() + 3;
let month = result.getMonth();
let day = result.getDate();
result = new Date(year, month, day);


console.log(result);

// -2208995816000
// -2208958016000

let birthday = new Date(1998, 3, 20);
let milisecond = now - birthday;
let second = milisecond / 1000;
let minute = second / 60;
let hour = minute / 60;
let dayCount = hour / 24;
console.log(dayCount);
console.error(dayCount);
// ARAŞTIRMA ÖDEVİ : Get time ı 0 olan tarih nedir?


