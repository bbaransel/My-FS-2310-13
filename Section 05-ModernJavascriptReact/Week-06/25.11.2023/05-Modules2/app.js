import { arrayASC, getArray, arrayDESC } from "./MyModules/sort-array.js";


const randomNumber = getArray(10);
console.log(randomNumber);
console.log(arrayASC(randomNumber));
let stringArray = ["ece", "Cagdas", "Furkan", "Melisa", "Baransel"]
console.log(arrayASC(stringArray));
console.log(arrayDESC(randomNumber));

