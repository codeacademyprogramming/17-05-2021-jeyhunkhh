// class Person {
//     constructor(mail, password) {
//         this.mail = mail;
//         this.password = password;
//     }
    
// }

// let person = new Person("ceyhun@mail.ru", "asdfgh");
// console.log(person);
// console.log(`Mailiniz: ${person.mail}, Parolunuz: ${person.password}`);

// adi
// qiymeti
// anbarda miqdar


class Produc{
    constructor(name, count, price){
        this.count = count;
        this.name = name;
        this.price = price;
        
    }

    buy(producname, kq, pul){
        if( producname != this.name){
            console.log(`Bu adda mehsul yoxdu`)
            return;
        }
        if( kq > this.count){
            console.log("isteyiniz miqdarda mehsul yoxdu");
            return;
        }
        
        let money = this.price*kq;
        console.log(`Mehsulun umumi deyeri ${money}`)

        if(pul < money){
            console.log("sizin pulunuz azdi");
            kq = pul / this.price
            console.log(`Ala bileceyiniz mebleq ${kq}kq.dir`)
            return;
        }

         this.count -= kq;
         console.log(`Siz mehsulu aldiniz`)
         console.log(`Sizin pulun qaliqi ${pul - money} manat`)
         console.log(`anbarinizda ${this.count} kq var`);
    } 
    
    

}


let custumer = new Produc("alma", 50, 2 );

custumer.buy( "alma",10, 20);

custumer.buy("saftali", 10, 19);

custumer.buy("alma", 15, 50);

custumer.buy("alma", 10, 5);

console.log(custumer)
