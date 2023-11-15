let result;

result = parseInt("10.9374634673") // "" da çalışır. rakam görmediği ilk yerden sonrasını atıyor.

result = parseFloat("100.12")

let num = 10.37853;
result = parseFloat(num.toFixed(4));
result = num.toFixed(4);
result = num.toPrecision(4);

result = Math.round(2.4);
result = Math.round(2.5);
result = Math.ceil(2.1);
result = Math.floor(2.9);
result = Math.round(2.4999);
result = Math.pow(5, 2);
result = Math.pow(4, 3);
result = Math.sqrt(25);
result = Math.sqrt(64);
result = Math.abs(-10);
result = Math.min(12, 48, 89, 5);
result = Math.max(12, 48, 89, 5);
result = Math.random();
result = parseInt(Math.random() * 100);






console.log(result, typeof result);