import { MatButtonModule, MatCheckboxModule } from '@angular/material';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSidenavModule } from '@angular/material/sidenav';
import { NgModule } from '@angular/core';
import { MatGridListModule } from '@angular/material/grid-list';

@NgModule({
  imports: [MatButtonModule, MatCheckboxModule, MatInputModule, MatFormFieldModule, MatSidenavModule, MatGridListModule],
  exports: [MatButtonModule, MatCheckboxModule, MatInputModule, MatFormFieldModule, MatSidenavModule, MatGridListModule]
})
export class MaterialModule {}
