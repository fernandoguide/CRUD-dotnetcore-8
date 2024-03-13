import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ApiService } from '../api.service';
import { ClienteRequest } from '../model/cliente.model';

@Component({
  selector: 'app-faleconosco',
  templateUrl: './faleconosco.component.html',
  styleUrl: './faleconosco.component.css'
})
export class FaleConoscoComponent {

  form = this.formBuilder.group({
    nome: ['', Validators.required],
    telefone: ['', [Validators.required]],
    email: ['', [Validators.required, Validators.email]],
    mensagem: ['', Validators.required],
  });
  constructor(
    private formBuilder: FormBuilder,
    private api: ApiService,
  ) { }

  onSubmit() {
    const body: ClienteRequest = {
      nome: this.form.controls.nome.value!,
      email: this.form.controls.email.value!,
      mensagem: this.form.controls.mensagem.value!,
      telefone: this.form.controls.telefone.value!,
    }
    this.api.enviarMensagem(body);
    this.limpar();
  }
  limpar() {
    this.form.controls.email.setValue('');
    this.form.controls.telefone.setValue('');
    this.form.controls.mensagem.setValue('');
    this.form.controls.nome.setValue('');
  }

}
