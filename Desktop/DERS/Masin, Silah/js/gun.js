class Gun {
    constructor(pistolCapacity) {
        this.pistolCapacity = pistolCapacity;
        this.currentPistol = 0;
        this.pistolCount = 0;
    }


    shoot(count) {
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
    }

    reload() {
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
    }

    addPistol(pistol) {
        this.pistolCount += pistol;
        console.log(`Çantaya ${pistol} güllə əlavə edildi`);
    }
}


let ak74 = new Gun(30);
ak74.addPistol(100);
ak74.reload();
ak74.shoot(3);

console.log(ak74);

let m416 = new Gun(40);
m416.addPistol(50);
m416.reload();
m416.shoot(5);
m416.reload();

console.log(m416);

let akm = new Gun(5);

akm.addPistol(20);
akm.reload();
akm.shoot(1);
akm.shoot(1);
akm.reload();

console.log(akm);
