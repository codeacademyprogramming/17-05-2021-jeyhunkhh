// class CoffeeMachine {
//     #waterAmount = 0;

//     get waterAmount() {
//         return this.#waterAmount;
//     }

//     set waterAmount(value) {
//         if (value <= 0) throw new Error("Negative water");
//         this.#waterAmount = value;
//     }

// }


// let machine = new CoffeeMachine(100);


class Car {
    constructor(fuelUsage, fuelCapacity) {
        this.fuelUsage = fuelUsage;
        this.fuelCapacity = fuelCapacity;
        this.currentFuel = 0;
        this.localKm = 0;
        this.globalKm = 0
    }


    drive(km) {
        if (km * this.fuelUsage / 100 > this.currentFuel) {
            throw new Error("Yanacaqla bu km gedile bilmez");
        }

        this.globalKm += km;
        this.localKm += km;
    }

    addFuel(litr) {
        if (litr + this.currentFuel > this.fuelCapacity) {
            throw new Error("Siz bu qeder yanacaq elave ede bilmezsiniz");
        }
        this.currentFuel += litr;
    }
}


let lada = new Car(8, 60);

lada.addFuel(40);

try {
    lada.addFuel(40);
} catch (err) {
    console.log(err);
}


try {
    lada.drive(50);
    console.log("Sizm masini surdunuz");
} catch (err) {
    console.log(err.message)
}
