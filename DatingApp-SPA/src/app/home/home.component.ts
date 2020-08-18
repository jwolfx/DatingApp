import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  registerMode: boolean;

  constructor() { }

  ngOnInit(): void {
    this.registerMode = false;
  }

  openRegisterMode(): void {
    this.registerMode = true;
  }

  cancelRegisterMode(registerMode: boolean): void {
    this.registerMode = false;
  }
}
