class Animal {
    constructor(name) {
        this.speed = 0;
        this.name = name;
    }
    run(speed) {
        this.speed = speed;
        console.log(`${this.name} runs with speed ${this.speed}.`);
    }
    stop() {
        this.speed = 0;
        console.log(`${this.name} stands still.`);
    }
}


class Rabbit extends Animal {

    constructor(name, earLength) {
        super(name);
        this.earLength = earLength;
    }

    hide() {
        console.log(`${this.name} hides!`);
    }

    show() {
        console.log(`${this.name} show!`);
    }

    stop() {
        console.log("overredited");
    }
}

class ArabianRabbit extends Rabbit {

    constructor(name, region) {
        super(name, 10);
        this.region = region;
    }

    Prayer() {
        super.stop(3);
    }
}


// let rabbit = new Rabbit("White Rabbit", 10);
// rabbit.test();


let a = new ArabianRabbit("Malik ibn Musa", "Simali Afrika");
