import { component } from "angular2/core";

@component({
    selector: "my-app",
    templateUrl: "my_app.html"

})

export class MyApp {
    public pessoa = {};

    public onOff: boolean = false;

    public onLigaDesliga() {
        this.onOff = !this.onOff;
    }

    public pessoas = [];

    public onIncluir() {
        this.pessoas.push(this.pessoa);
    }
}