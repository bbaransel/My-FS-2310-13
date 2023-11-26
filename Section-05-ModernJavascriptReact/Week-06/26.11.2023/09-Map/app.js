// let numbers = [3, 9, 14, 20, 19];
// let evenNumbers = numbers.map(nextNumber => {
//     if (nextNumber % 2 == 0) return nextNumber;
// });
// console.log(numbers);
// console.log(evenNumbers);




let prices = [40, 50, 100, 200, 250];
let newPrices = prices.map(nextPrice => {
    return nextPrice * 1.2;
});
console.log(prices);
console.log(newPrices);