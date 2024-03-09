// console.log("Hello Node.js");

// let number1 = 50;
// let number2 = 40;
// let number3 = 60;
// let result = (number1/2)+number2-number3;
// console.log(`sayıların toplamı: ${result}`);

const products = [
    { id: 1, name: "Iphone 15", price: 89000 },
    { id: 2, name: "Samsung S22", price: 55000 },
    { id: 3, name: "Xaomi 19", price: 34000 },
    { id: 4, name: "Nothing 1", price: 21000 },
]
let result = 0
products.forEach(element => {
    result += element.price
});
console.log(result);