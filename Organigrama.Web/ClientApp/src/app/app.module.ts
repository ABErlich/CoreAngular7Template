import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './layout/app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { HeadComponent } from './layout/head.component';
import { LeftPanelComponent } from './layout/left-panel.component';
import { AppRoutingModule } from './app-routing.modules';
import { LoginComponent } from './components/login/login.component';
import { LogoutComponent } from './components/login/logout.component';
import { Helpers } from './helpers/helpers';
import { TokenService } from './services/token.service';
import { AppConfig } from './config/config';

import { MatButtonModule, MatCheckboxModule } from '@angular/material';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSidenavModule } from '@angular/material/sidenav';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    HeadComponent,
    LeftPanelComponent,
    LoginComponent,
    LogoutComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    BrowserAnimationsModule,
    MatButtonModule,
    MatCheckboxModule,
    MatInputModule,
    MatFormFieldModule,
    MatSidenavModule,
    HttpClientModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [Helpers, TokenService, AppConfig ],
  bootstrap: [AppComponent]
})
export class AppModule { }
