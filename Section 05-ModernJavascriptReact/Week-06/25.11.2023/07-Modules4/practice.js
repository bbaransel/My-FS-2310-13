export const randomNumber = (maxNumber) => Math.floor(Math.random() * maxNumber) + 1;

export const getArray = (count) => {
    const resultArray = [];
    for (let i = 0; i < count; i++) {
        resultArray.push(randomNumber(100));
    }
    return resultArray;
}

export const evenNums = (...arrayNumbers) => {
    let arrayEven = [];
    for (let i = 0; i < arrayNumbers.length; i++) {
        if (arrayNumbers[i] % 2 == 0) arrayEven.push(arrayNumbers[i]);
    };
    return arrayEven;
};
export const oddNums = (...arrayNumbers) => {
    let arrayOdd = [];
    for (let i = 0; i < arrayNumbers.length; i++) {
        if (arrayNumbers[i] % 2 != 0) arrayOdd.push(arrayNumbers[i]);
    };
    return arrayOdd;
}

export const getEvenNumbers = (numbers) => {
    const result = [];
    for (const i in numbers) {
        if (numbers[i] % 2 == 0) result.push(numbers[i]);
    }
    return result;
}

export const getOddNumbers = (numbers) => {
    const result = [];
    for (const nextNumber of numbers) {
        if (nextNumber % 2 != 0) result.push(nextNumber);
    }
    return result;
}


// export const randomNumber = (maxNumber) => Math.floor(Math.random() * maxNumber) + 1;
// export const all numbers = (maxNumber, count) => {
//     let randomNums =[];
//     Math.floor(Math.random() * maxNumber) + 1;
//     const resultArray = [];
//     for (let i = 0; i < count; i++) {
//         resultArray.push(randomNumber(100));
//     }
//     return resultArray;
// }











// İkisi tek döngüde
export const oddOrEven = (...arrayNumbers) => {
    let evens = [];
    let odds = [];
    for (let i = 0; i < arrayNumbers.length; i++) {
        if (arrayNumbers[i] % 2 == 0) {
            evens.push(arrayNumbers[i]);
        } else {
            odds.push(arrayNumbers[i]);
        }
    };
    let result = { orjinal: arrayNumbers, EvenNumbers: evens, OddNumbers: odds }
    return result;

};




// 3 ü tek döngüde
export const getResult = () => {
    let number;
    const allNumbers = [];
    const oddNumbers = [];
    const evenNumbers = [];
    for (let i = 0; i < 10; i++) {
        number = Math.ceil(Math.random() * 100);
        allNumbers.push(number);
        if (number % 2 == 0) {
            evenNumbers.push(number);
        } else {
            oddNumbers.push(number);
        }
    }
    let result = {
        all: allNumbers,
        odds: oddNumbers,
        evens: evenNumbers
    }
    return result;
};















