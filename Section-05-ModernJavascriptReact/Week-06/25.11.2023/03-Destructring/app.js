// let fullName = ["Kemal", "Candan", "asdasd"];
// // let firstName = fullName[0];
// // let lastName = fullName[1];

// let [firstName, lastName, asd, asdf] = fullName;
// console.log(firstName, lastName, fullName, asd, asdf);


// let fullName = "Mustafa Kemal Atatürk";
// let [name1, name2, name3] = fullName.split(" ");
// // let [name1, name2, name3] = fullName;

// console.log(name1, name2, name3);

// let userInfo = ["enginniyazi", "engin niyazi", "ergül", 48, "istanbul", "türkiye"];

// // let [username, firstName, lastName, age, city, country] = userInfo
// let [username, firstName, lastName, age, ...adress] = userInfo;



// console.log(username, firstName, lastName, age, adress.join(" "));

// console.log(adress.join("/"));

let product = {
    productName: "Adidas",
    price: 2750,
    model: "Runner2023",
    color: "red"
}

let { productName, price, model, color, size } = product;



console.log(productName, price, model, color, size);
console.log(product);
product.size = "XL";
console.log(product.size);


















