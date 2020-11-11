import { Component, OnInit } from '@angular/core';
import { LoaisanphamService } from '../../shared/services/loaisanpham.service';
import { DanhmucsanphamService } from '../../shared/services/danhmucsanpham.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private danhmucService : DanhmucsanphamService, private loaisanphamServic : LoaisanphamService) { }

  public menus: any[];
  public loai: any[];
  ngOnInit(): void {
    this.getMenu();
  }
  getMenu() {
    this.danhmucService.getLink().subscribe(res => {
      this.menus = res;
      for(let menu of this.menus){
        // console.log(menu.madanhmuc);
        this.danhmucService.getLinkChild(menu.madanhmuc).subscribe(res=>{
          this.loai =res;
          console.log(this.loai);
        });
      }
    });
    
  }

}
