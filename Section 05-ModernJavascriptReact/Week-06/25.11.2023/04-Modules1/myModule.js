export const getTotal = (...numbers) => {
    const numbersArray = [...numbers];
    let total = 0;
    for (let i = 0; i < numbersArray.length; i++) {
        total += numbersArray[i];
    }
    return total;
};


// export { getTotal }
