import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servicos";

@Component({

    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls:["./login.component.css"]
})

export class LoginComponent implements OnInit {
   

    public usuario;
    public usuarioAutenticado: boolean;
    public returnUrl: string;
    public mensagem: string;
    constructor(private router: Router, private activatedRouter: ActivatedRoute,
        private usuarioServico: UsuarioServico) {
      //  this.usuarioServico.verificarUsuario(this.usuario);
       
    }


  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
}

    entrar() {

        this.usuarioServico.verificarUsuario(this.usuario).subscribe(
            usuario_json => {
                this.usuarioServico.usuario = usuario_json;
                if (this.returnUrl == null) {
                    this.router.navigate(["/"]);

                } else {
                    this.router.navigate([this.returnUrl]);
                }
            },  
            err => {
                console.log(err.error);
                this.mensagem = err.error;

            }
        );

        //if (this.usuario.email == "a@a" && this.usuario.senha == "a") {
        //    sessionStorage.setItem("usuario-autenticado", "1");
        //    this.router.navigate([this.returnUrl]);
        //}
    }

}