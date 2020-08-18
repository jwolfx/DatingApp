import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  @Output() cancelRegister = new EventEmitter();

  model: any = {};

  constructor(private authService: AuthService) { }

  ngOnInit(): void {
  }

  register(): void {
    this.authService.register(this.model)
    .subscribe(
      () => {
        console.log('Register OK', this.model);
      },
      (error) => {
        console.log('Error', error);
      }
    );

  }

  cancel(): void {
    console.log('Cancel');
    this.cancelRegister.emit(false);
  }
}
