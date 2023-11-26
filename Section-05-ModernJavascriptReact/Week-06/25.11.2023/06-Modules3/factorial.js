// Kendisine verilen sayının faktöriyelini hesaplayan ve geri döndüren bir function hazırlayın.

const calculateFactorial = number => {
    if (number == 0 || number == 1) return 1;
    for (let i = number - 1; i >= 1; i--) {
        number = number * i;
    }
    return number;
};

const display = () => {
    console.log("Merhaba");
}









export { display };

export default calculateFactorial;