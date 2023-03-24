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
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClient, HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { OnboardModule } from './onboard/onboard.module';
import { HeadersInterceptor } from './interceptors/headers.interceptor';
import { AuthGuard } from './guards/auth.guard';

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
    OnboardModule,
    FormsModule
  ],
  providers: [
    {provide:HTTP_INTERCEPTORS, useClass:HeadersInterceptor, multi:true},
    AuthGuard
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
