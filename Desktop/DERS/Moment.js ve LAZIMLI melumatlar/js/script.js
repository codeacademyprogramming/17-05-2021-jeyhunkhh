let city = "Baku, u";

// city.length->4

// console.log(city.toUpperCase());
// console.log(city.toLowerCase());
// console.log(city.substr(1));

// console.log(city.length);
// console.log(city.trim().length);

// console.log(city.replace(/u/gi,"ı"));

// console.log(city.indexOf("u",4));

// console.log(city.includes("j"));

// console.log(city.startsWith("b"));

// console.log(city.endsWith("z"));

// console.log(city.charAt(1));

// console.log(city.charCodeAt(0));

// var names = "Ceyhun,Vusal,Mecid";

// console.log(names);


// let arr = [];
// let s = ",";
// let lastTrimIndex = 0;

// for (let i = 0; i < names.length; i++) {
//     if (names.charAt(i) == s) {
//         let name = names.slice(lastTrimIndex, i);

//         arr.push(name);

//         lastTrimIndex = i + 1;
//     }

//     if (i + 1 == names.length) {
//         let name = names.slice(lastTrimIndex, names.length);

//         arr.push(name);
//     }
// }

// console.log(arr);

// let price = 5.965231;

// console.log(price.toFixed(2));

// let age = "21.2a43";

// age = parseFloat(age);

// console.log(age);

// let ages = [25, 26, 27, 26];
// let olderAges = [30, 31, 33, 101];

// let classAges = ages.concat(olderAges);

// for(let i=0;i<ages.length;i++){
//     console.log(ages[i]);
// }

// ages.push(28);
// ages.pop();

// ages.shift();
// ages.unshift(24);

// ages.splice(0, 0, 32, 45);

// console.log(ages.indexOf(26));
// console.log(ages.lastIndexOf(26));

// console.log(ages.toString());


// console.log(classAges.slice(2,4));

// console.log(classAges);

// console.log(classAges.sort(function (a, b) { return a - b }));

// let people = [];

// people.push({
//     name: "Ilkana",
//     age: 24
// });

// people.push({
//     name: "Ceyhun",
//     age: 26
// });

// people.push({
//     name: "Vusal",
//     age: 23
// });

// people.sort(function (a, b) { return a.age - b.age })
// people.reverse();

// console.log(people);


// let ages = [25, 26, 27, 28];


// ages.forEach((value, i) => {
//     console.log(i, value);
// });


// let people = [];

// people.push({
//     name: "Ilkana",
//     age: 24,
//     payment: 500
// });

// people.push({
//     name: "Ceyhun",
//     age: 26,
//     payment: 400
// });

// people.push({
//     name: "Vusal",
//     age: 23,
//     payment: 200
// });

// var people2 = people.map((item, i) => {
//     return {
//         name:item.name,
//         age:item.age,
//         group:"P115"
//     };
// });


// let people3 = people.filter((item) => {
//     return item.name.startsWith("V");
// });

// let totalPayment = people.reduce((sum, item,i) => {
//     return sum.payment+item.payment;
// });

// console.log(totalPayment);

// let paymentOver1000 = people.some((item) => {
//     return item.payment >= 1000;
// });

// let finded = people.findIndex((item)=>{
//     return item.age>25;
// });

// console.log(finded);

// let birthday = new Date(1992,11,20,17,35,24,9);

// let now = new Date();

// let diffWithSecond = now.getTime() - birthday.getTime();
// console.log(Math.ceil(diffWithSecond/1000/60/60/24/365).toFixed(0));

// console.log(moment().format("DD.MM.YYYY, H:mm:ss"));

// let novruz = moment("20200321","YYYYMMDD");

// console.log(novruz.subtract(4,"M").format());

// console.log(Math.round(2.6));

// console.log(Math.floor(2.9));

// console.log(Math.ceil(3.2));

// console.log(Math.pow(16,2));

// console.log(Math.sqrt(Math.abs(-16)));

// console.log(Math.pow(81,1/4))

// console.log(getRndInteger(50, 100));

// function getRndInteger(min, max) {
//     return Math.floor(Math.random() * (max - min + 1)) + min;
// }

let changeBtn = document.querySelector("#change-btn");
let displayImage = document.querySelector("#display-image");


changeBtn.onclick = function () {
    let src = displayImage.getAttribute("src");
    
    if (src == "img/baku.jpg") {
        displayImage.setAttribute("src", "img/sumqayit.jpg")
    } else {
        displayImage.setAttribute("src", "img/baku.jpg")
    }
}