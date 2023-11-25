function selamVer() {
    console.log("Merhaba, burası klasik bir function");
}

const selamVer2 = () => {
    console.log("Merhaba, burası bir arrow function");
}

const selamVer3 = (ad) => {
    console.log(`Merhaba ${ad}`);
}

const topla = (sayi1 = 0, sayi2, sayi3 = 0) => {
    return sayi1 + sayi2 + sayi3
}

const selamVer4 = ad => {
    console.log(`Merhaba ${ad}`)
}

const topla2 = (sayi1, sayi2) => sayi1 + sayi2;










selamVer();
selamVer2();
selamVer3("Engin");
console.log(topla(null, 1));
selamVer4("Halil");
console.log(topla2(1, 2));

