import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MasterlayoutComponent } from './layout/masterlayout/masterlayout.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { InterviewModule } from './interview/interview.module';
import { RecruitModule } from './recruit/recruit.module';
import { LoginComponent } from './login/login.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { OnboardModule } from './onboard/onboard.module';

@NgModule({
  declarations: [
    AppComponent,
    MasterlayoutComponent,
    HeaderComponent,
    FooterComponent,
    LoginComponent,
    PageNotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    InterviewModule,
    RecruitModule,
    OnboardModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
