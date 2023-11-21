
//Bir function scope'u içinde let ile tanımlanan değişken, sadece o function'da geçerlidir.
// function print(){
//     let name = "Zeynep Nur Ay";
//     console.log(name);
// }

// if (true) {
//     let price = 45;
//     console.log(price);
// }

// print();

// console.log(price);

//ES5 öncesinde JS'te değişken tanımlamak için var ve const keywordleri vardı.

//ES5 ile birlikte bunlara let eklendi.




function print() {
    var name = "Zeynep Nur Ay";
    console.log(name);
}

if (true) {
    var price = 56;
}
print();

console.log(name);
console.log(price);