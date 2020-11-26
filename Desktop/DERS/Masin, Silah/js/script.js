// var person = {
//     name: "Yolchu",
//     surname: "Nasib",
//     birthyear: 1992,
//     fullname: function () {
//         return this.name + " " + this.surname;
//     },
//     calcAge: function (currentYear) {
//         return currentYear - this.birthyear;
//     }
// }

// console.log(person.fullname());

// console.log(person.calcAge(2020));

let car = {
    currentFuel: 0,
    fuelUsage: 12,
    fuelCapacity: 60,
    localKm: 0,
    globalKm: 0,

    drive: function (km) {
        if (km * this.fuelUsage / 100 > this.currentFuel) {
            console.log("Cari yanacaqla bu qədər yolu gedə bilməzsiniz");
            return;
        }

        this.currentFuel -= km * this.fuelUsage / 100;
        this.localKm += km;
        this.globalKm += km;

        console.log(`${km} km maşın sürüldü, cari yanacaq : ${this.currentFuel} litrdir`);
    },
    addFuel: function (litr) {
        if (litr + this.currentFuel > this.fuelCapacity) {
            console.log("Bu qədər yanacaq əlavə edə bilməzsiniz")
            return;
        }

        this.currentFuel += litr;
        console.log(`${litr} litr yanacaq əlavə olundu, cari yanacaq : ${this.currentFuel} litrdir`);
    },
    resetLocalKm: function () {
        this.localKm = 0;
        console.log("Maşının localkm-i sıfırlandı");
    }
}

// car.addFuel(10);

// car.drive(50);

// car.addFuel(50);

// car.drive(200);

// car.resetLocalKm();

// car.drive(20);

// console.log(car);

let gun = {
    currentPistol: 10,
    pistolCapacity: 30,
    pistolCount: 20,

    shoot: function (count) {
        if (count == undefined) {
            return false;
        }

        if (typeof (count) != "number") {
            return false;
        }

        if (count > this.currentPistol) {
            console.log("Atmaq istədiyiniz qədər güllə yoxdur");
            return false;
        }

        this.currentPistol -= count;

        console.log(`${count} güllə atıldı, daraqda ${this.currentPistol} güllə qaldı`);
        return true;
    },

    reload: function () {
        if (this.currentPistol == this.pistolCapacity) {
            console.log("Daraqda güllə sayı tamdır");
            return false;
        }

        if (this.pistolCount == 0) {
            console.log("Çantanızda güllə yoxdur")
            return false;
        }

        let diff = this.pistolCapacity - this.currentPistol;

        if (this.pistolCount > diff) {
            this.currentPistol = this.pistolCapacity;
            this.pistolCount -= diff;
        } else {
            this.currentPistol += this.pistolCount;
            this.pistolCount = 0;
        }

        console.log(`Daraqda ${this.currentPistol} güllə var, çantada isə ${this.pistolCount} güllə qaldı`)
    },

    addPistol: function (pistol) {
        this.pistolCount += pistol;
        console.log(`Çantaya ${pistol} güllə əlavə edildi`);
    }
}



// currentPistol: 10; 5 25 5 1 1 30 5 16
// pistolCapacity: 30; 30 30 30 30 30 30
// pistolCount: 20; 20 0 0 0 40 11 11 0


gun.shoot(5);

gun.reload();

gun.shoot(20);

gun.shoot(4);

gun.addPistol(40);

gun.reload();

gun.shoot(25);

gun.reload();

console.log(gun);