import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';
import { User } from 'src/app/shared/models/user';


@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css']
})
export class UserDetailsComponent implements OnInit {

  userDetails!: User;
  id: number = 0;

  constructor(private userService: UserService, private activeRoute: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {



    this.activeRoute.paramMap.subscribe
      (
        p => {
          this.id = Number(p.get('id'));
          console.log('User Id= ' + this.id);
          // call the api
          this.userService.getUserById(this.id)
            .subscribe(
              m => {
                this.userDetails = m;
                console.log(this.userDetails);
              }
            );
        }
      )
      
    console.log('inside user details component');
  }


  deleteUser() {
    let id
    this.activeRoute.url.subscribe(u => id = u[1].path)
    id = Number(id)
    this.userService.deleteUser(id).subscribe(resp => {if (resp) {this.router.navigate(['/user'])}})
  }
}    