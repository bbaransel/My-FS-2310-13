let numbers = [3, 9, 14, 20, 19];
let newNumbers = numbers.map(nextNumber => {
    if (nextNumber >= 10) return true;
})

console.log(numbers);
console.log(newNumbers);


// let newNumbersFilters = numbers.filter(nextNumber => {
//     if (nextNumber >= 10) return true;
// })

let newNumbersFilters = numbers.filter(nextNumber => nextNumber >= 15);

console.log(newNumbersFilters);