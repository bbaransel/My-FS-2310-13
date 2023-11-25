import { evenNums, getArray, oddNums, getEvenNumbers, getOddNumbers, oddOrEven, getResult } from "./practice.js";



let arrayNums = getArray(10);
console.log("orjinal hali " + arrayNums);

console.log("even " + evenNums(...arrayNums));
console.log("odd " + oddNums(...arrayNums));


console.log(getEvenNumbers(arrayNums));
console.log(getOddNumbers(arrayNums));
console.log(oddOrEven(...arrayNums));
let result = getResult();
console.log(result);
console.log("Orjinal hali " + result.all);
console.log("Tek sayılar " + result.odds);
console.log("Çift sayılar " + result.evens);













// Rastgele üretilecek 1 ile 100 arasındaki 10 adet sayıyı kullanarak bir dizi oluşturun.
// -Bu oluşturulan dizi içerisindeki tek sayıları tespit edip döndüren bir function
// -Bu oluşturulan dizi çerisindeki çift sayıları tespit eden dödüren bir function içeren bir module dosyasını hazırlayıp, app.js içinde kullanın.