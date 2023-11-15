let courseName = "Fullstack Web Developer Eğitimi";
let result;

result = courseName.toLowerCase();
result = courseName.toLocaleLowerCase();
result = courseName.toUpperCase();
result = courseName.toLocaleUpperCase();


result = courseName.length // Property Özellik

result = courseName[0];
result = courseName[14];
result = courseName[125];



result = courseName.slice(14, 23)


result = courseName.replace("Eğitimi", "Kursu")

result = courseName.trim()
result = courseName.trimStart()
result = courseName.trimEnd()



result = courseName.indexOf("F", 0)

// result = courseName.split(" "); // boşluktan sonra bölüyor
result = courseName.split(""); // her karakterden sonra bölüyor
result = courseName.startsWith("F");
result = courseName.endsWith("")



console.log(result);


// indexOf ile ilgili örnek;

// let message;
// let findedText;
// message = prompt("Lütfen metni giriniz. ");
// findedText = prompt("Lütfen arayacağınız metni ya da karakteri giriniz.");
// result = message.indexOf(findedText);
// if (result == -1) {
//     alert(message + " içinde " + findedText + " bulununamamıştır.")
// } else {
//     alert(message + " içinde '" + findedText + "' " + ++result + ". sırada bulunmuştur.")
// }






