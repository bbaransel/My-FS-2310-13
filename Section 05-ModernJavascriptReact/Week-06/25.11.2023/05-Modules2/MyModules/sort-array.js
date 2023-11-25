// 0 ile maxNumber arasında rastgele sayı üretir.
// const randomNumber = (maxNumber) => Math.floor((Math.random() * maxNumber) + 1) + 1;
const randomNumber = maxNumber => Math.ceil(Math.random() * maxNumber);

export const arrayASC = array => {
    // return array.sort((a, b) => a - b);
    return array.sort(compareNumericASC);
}

export const arrayDESC = array => {
    // let result = arrayASC(array);
    // return result.reverse();
    return array.sort((a, b) => b - a);
}

const compareNumericASC = (a, b) => {
    // if (a > b) {
    //     return 1;
    // } else if (a == 0) {
    //     return 0;
    // } else {
    //     return -1;
    // }
    if (a > b) return 1;
    if (a == 0) return 0;
    return -1
}





export const getArray = (count) => {
    const resultArray = [];
    for (let i = 0; i < count; i++) {
        resultArray.push(randomNumber(100));
    }
    return resultArray;
}




// function randomNumberOld(maxNumber) {
//     return Math.floor((Math.random() * maxNumber) + 1) + 1;
// }











