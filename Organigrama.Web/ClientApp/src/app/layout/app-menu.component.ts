import { Component } from '@angular/core';

@Component({
    selector: 'app-menu',
    templateUrl: './app-menu.component.html',
    styleUrls: ['./app-menu.component.css']
})

export class MenuComponent{
  position: string = "Empleado";
  date: Date = new Date();
  title = 'Organigrama';

}
