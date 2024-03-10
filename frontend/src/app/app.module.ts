import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from "./app-routing.module";

import { HomeComponent } from "./home/home.component";
import { FaleConoscoComponent } from "./faleconosco/faleconosco.component";
import { CuriosidadesComponent } from "./curiosidades/curiosidades.component";
import { LixoEletronicoComponent } from "./lixoeletronico/lixoeletronico.component";
import { HeaderComponent } from "./header/header.component";
import { SobreNosComponent } from "./sobrenos/sobrenos.component";
import { TermosCondicoesComponent } from "./termoscondicoes/termoscondicoes.component";
import { AppComponent } from "./app.component";

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
    HttpClientModule,
    AppRoutingModule,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
