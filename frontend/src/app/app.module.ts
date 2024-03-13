import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule, provideHttpClient, withFetch } from "@angular/common/http";

import { AppRoutingModule } from "./app-routing.module";

import { HomeComponent } from "./home/home.component";
import { FaleConoscoComponent } from "./faleconosco/faleconosco.component";
import { CuriosidadesComponent } from "./curiosidades/curiosidades.component";
import { LixoEletronicoComponent } from "./lixoeletronico/lixoeletronico.component";
import { HeaderComponent } from "./header/header.component";
import { SobreNosComponent } from "./sobrenos/sobrenos.component";
import { TermosCondicoesComponent } from "./termoscondicoes/termoscondicoes.component";
import { AppComponent } from "./app.component";
import { NgxMaskDirective, NgxMaskPipe, provideNgxMask } from "ngx-mask";
import { ApiService } from "./api.service";



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    FaleConoscoComponent,
    CuriosidadesComponent,
    LixoEletronicoComponent,
    HeaderComponent,
    SobreNosComponent,
    TermosCondicoesComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    NgxMaskDirective,
    NgxMaskPipe,
    ReactiveFormsModule,
    HttpClientModule,
    AppRoutingModule,
  ],
  bootstrap: [AppComponent],
  providers: [
    provideNgxMask(),
    provideHttpClient(),
    ApiService
  ]
})
export class AppModule { }
