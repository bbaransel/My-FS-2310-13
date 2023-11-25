const calculateCircleArea = (r, pi = 3) => {
    return `Bu dairenin alanı ${r * r * pi};`
}

const calculateCircleArea2 = (...parameters) => {
    let array = [...parameters];
    let r = array[0];
    let pi = array[1] == undefined ? 3 : array[1];
    return `Bu dairenin alanı ${r * r * pi};`

}









// console.log(calculateCircleArea(5, 3.14));
// console.log(calculateCircleArea(5));
// console.log(calculateCircleArea(5, 3.145683));
// calculateCircleArea2(5, 3.14);
// console.log(calculateCircleArea2(5, 3.14));

//Soru: içerisine gönderilen sayıların toplayım, sonucu ekrana yazıran arrow functionı hazırlayın.

const getTotal = (...numbers) => {
    // console.log(...numbers)
    let numbersArray = [...numbers];
    let total = 0;
    for (i = 0; i < numbersArray.length; i++) {
        total += numbers[i];
    }
    return total;
}

const basektItemsPrice = [135, 500, 900, 250];

// console.log(getTotal(1, 2, 3, 4, 2, 2, 21, 32, 3, 32323, 321,));
console.log(getTotal(...basektItemsPrice));
















