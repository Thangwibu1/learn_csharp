# Mo rong chi tiet: Unity Editor

## 1. Boi canh tong quan

- Unity Editor la noi ban lap rap tat ca cac manh cua game.
- Ban khong viet code xong roi game tu xuat hien.
- Ban se ket hop scene, asset, component, prefab, script, animation va UI trong editor.
- Neu hieu editor, toc do hoc Unity tang len rat nhanh.
- Neu khong hieu editor, ban se bi lac du hieu code C#.

## 2. Cach nghi dung ngay tu dau

- Hay nghi Unity nhu mot xưởng lap rap game.
- `Project` la kho vat tu.
- `Hierarchy` la danh sach do vat dang co trong canh hien tai.
- `Inspector` la bang thong so cua vat duoc chon.
- `Scene` la ban thao tac va dat do vat.
- `Game` la thu camera dang nhin thay khi choi.
- `Console` la noi bao loi, canh bao va thong tin debug.

## 3. Scene la gi

- Scene la mot manh cua tro choi.
- Mot game co the co nhieu scene.
- Vi du: menu chinh, man choi 1, man choi 2, man game over.
- Trong scene, ban sap xep GameObject vao dung vi tri.
- Scene khong phai toan bo du an.
- Scene cung khong phai la mot object don le.
- Scene la mot khong gian chua nhieu object hoat dong cung nhau.

## 4. Hierarchy dung de lam gi

- `Hierarchy` liet ke object dang ton tai trong scene.
- Moi dong thuong la mot `GameObject`.
- Ban co the dat ten object de de tim.
- Ban co the keo object vao trong object khac de tao quan he cha con.
- Khi gap project lon, dat ten ro rang se cuc ky quan trong.
- Ten tot vi du: `Player`, `Main Camera`, `EnemySpawner`, `PausePanel`.
- Ten xau vi du: `GameObject`, `Cube (3)`, `New Object`.

## 5. Inspector la trai tim cua viec chinh sua

- Khi chon mot object, `Inspector` hien thong tin cua no.
- Ban se thay danh sach component gan tren object.
- Moi component la mot nhom chuc nang rieng.
- Ban sua so lieu, checkbox, reference va script tai day.
- Day la noi lien ket asset vao script bang thao tac keo tha.
- Day cung la noi ban bat tat component.
- Nguoi moi rat hay sua nham object vi khong nhin ky Inspector.

## 6. Project window la kho asset

- `Project` chua file trong du an.
- Cac thu muc thuong gap la `Scenes`, `Scripts`, `Prefabs`, `Sprites`, `Materials`, `Audio`.
- Asset khong nhat thiet dang ton tai trong scene.
- Asset co the duoc tai su dung o nhieu scene khac nhau.
- Script C# la mot asset.
- Prefab la mot asset.
- Hinh anh, am thanh, animation clip cung la asset.

## 7. Scene view va Game view khac nhau ra sao

- `Scene` dung de chinh sua the gioi.
- `Game` dung de xem ket qua tu camera.
- Trong `Scene`, ban co the thay gizmo, luoi, icon object.
- Trong `Game`, ban thay hinh anh nguoi choi se thay.
- Neu nhan Play ma camera khong nhin dung huong, `Game` se cho ket qua khac `Scene`.
- Day la ly do phai biet phan biet hai cua so nay.

## 8. Thanh cong cu co y nghia gi

- `Move` dung de di chuyen object.
- `Rotate` dung de xoay object.
- `Scale` dung de doi kich thuoc.
- `Rect Tool` rat hay dung cho UI 2D.
- `Transform gizmo` giup ban keo truc X, Y, Z truc quan.
- Khi moi hoc, hay chuyen qua lai giua cong cu de quen tay.

## 9. Play Mode la gi

- Nut `Play` cho editor chay game tam thoi.
- Ban co the thu input, va cham, UI, am thanh.
- Khi thoat `Play Mode`, nhieu thay doi trong scene co the bi mat.
- Day la diem rat de gay nham lan cho nguoi moi.
- Neu ban keo object trong luc Play va thay no hop ly, chua chac thay doi do duoc luu.
- Hay kiem tra lai sau khi tat Play.

## 10. Console quan trong nhu the nao

- `Console` hien loi bien dich script.
- `Console` hien exception khi game dang chay.
- `Console` hien canh bao ve thiet lap chua on.
- `Debug.Log` se in thong tin ra day.
- `Debug.LogWarning` dung cho canh bao.
- `Debug.LogError` dung cho loi nghiem trong.
- Hoc doc Console som se giup tiet kiem rat nhieu gio.

## 11. Quy trinh tao object co ban

1. Tao mot object moi trong `Hierarchy`.
2. Dat ten ro rang.
3. Chon object va xem `Inspector`.
4. Gan component can thiet.
5. Dieu chinh `Transform`.
6. Keo asset vao neu can.
7. Nhan Play de kiem tra.

## 12. Asset va instance

- Asset la file nguon trong `Project`.
- Instance la ban sao dang duoc dat trong scene.
- Prefab la asset dac biet co the sinh ra nhieu instance.
- Sua prefab co the anh huong nhieu noi su dung.
- Sua instance chi anh huong object trong scene do.
- Hieu asset va instance giup tranh sua nham quy mo lon.

## 13. Vi du gan gui cho nguoi moi

- Ban co hinh anh nhan vat trong `Project`.
- Ban keo no vao `Scene`.
- Unity tao mot object trong `Hierarchy`.
- Object do co the co `SpriteRenderer` de hien hinh.
- Sau do ban gan them `BoxCollider2D`.
- Tiep theo ban gan `Rigidbody2D`.
- Cuoi cung ban gan script `PlayerController`.
- Luc nay nhan vat moi that su co mat trong game.

## 14. Thu muc nen sap xep som

- `Assets/Scenes`
- `Assets/Scripts`
- `Assets/Prefabs`
- `Assets/Sprites`
- `Assets/Materials`
- `Assets/Animations`
- `Assets/Audio`
- `Assets/UI`

## 15. Vi sao sap xep du an quan trong

- Du an lon se co rat nhieu file.
- Neu khong co quy tac, tim file rat lau.
- Team cung kho hop tac hon.
- Nguoi moi thuong danh mat script vi de lung tung.
- Cang hoc som, ban cang de giu project gon gang.

## 16. Main Camera va huong nhin

- `Main Camera` quyet dinh nguoi choi thay gi.
- Trong game 2D, camera thuong nhin truc tiep vao man hinh.
- Trong game 3D, camera co the xoay goc nhin phuc tap hon.
- Neu object co trong scene ma camera khong nhin thay, `Game` se trong nhu rong.
- Do do, luon kiem tra camera khi gap van de hien thi.

## 17. Gizmos va bieu tuong ho tro

- Gizmo la cac ky hieu ho tro trong `Scene`.
- No giup nhin camera, den, vung trigger, duong raycast.
- Gizmo khong phai noi dung that nguoi choi thay.
- Day la cong cu ho tro lap trinh va thiet ke.

## 18. Inspector va serialization

- Nhieu bien script duoc hien trong `Inspector`.
- Dieu nay cho phep chinh tham so ma khong can sua code.
- Vi du: toc do di chuyen, luong mau, sat thuong.
- Day la cach lam rat hop voi Unity.
- Lap trinh vien code logic.
- Designer co the chinh so lieu bang Inspector.

## 19. Phan biet component va file script

- File script trong `Project` chi la dinh nghia.
- Khi script duoc gan vao object, no tro thanh mot component dang hoat dong.
- Day la ly do mot script co the gan cho nhieu object khac nhau.
- Moi object se co du lieu rieng cua component do.

## 20. Lam viec voi prefab trong editor

- Prefab la mau object tai su dung.
- Ban tao prefab bang cach keo object tu scene vao `Project`.
- Sau do co the keo prefab ra scene nhieu lan.
- Day rat huu ich cho enemy, dan, vat pham, UI panel lap lai.
- Nguoi moi hoc editor som nen lam quen prefab ngay tu giai doan nhap mon.

## 21. Nhung thao tac can tap thanh tho quen

- Luu scene thuong xuyen.
- Dat ten object ro nghia.
- Nhin `Inspector` truoc khi chinh.
- Nhin `Console` khi game loi.
- Tao thu muc hop ly.
- Khong de file moi o lung tung trong `Assets`.

## 22. Loi thuong gap cua nguoi moi

- Keo nham asset vao scene roi khong biet no dang o dau.
- Tao qua nhieu object ten giong nhau.
- Quen luu scene.
- Sua object trong Play Mode roi nghi la da luu that.
- Khong nhin Console nen bo qua loi script.
- Xoa nham asset trong `Project`.

## 23. Meo ghi nho nhanh

- Chon object: nhin `Hierarchy`.
- Sua object: nhin `Inspector`.
- Dat object: nhin `Scene`.
- Kiem tra camera: nhin `Game`.
- Tim file: nhin `Project`.
- Tim loi: nhin `Console`.

## 24. Lien he voi cach nghi GameObject va Component

- Unity khong bat ban tao mot class khong lo cho moi vat the.
- Unity cho ban tao mot object roi gan nhieu component nho.
- Editor la noi ban thuc hien viec lap rap do.
- Vi vay, editor va tu duy component di cung nhau.

## 25. Bai tap tu quan sat editor

- Tao mot scene moi va luu vao thu muc `Scenes`.
- Tao `Player` rong trong `Hierarchy`.
- Them `SpriteRenderer` cho no.
- Them mot `BoxCollider2D`.
- Them script rong ten `PlayerController`.
- Chon tung component va doc ten cua cac truong trong Inspector.
- Nhan Play va quan sat Console.

## 26. Cau hoi tu kiem tra

- `Scene` va `Game` khac nhau o diem nao?
- `Project` khac `Hierarchy` o diem nao?
- Vi sao `Inspector` quan trong?
- Vi sao thay doi trong Play Mode co the khong duoc luu?
- Prefab giai quyet van de gi?

## 27. Ket noi voi bai sau

- Sau khi hieu editor, ban se hoc `GameObject` va `Component` de biet moi object trong hierarchy thuc chat la gi.
- Day la vien gach dau tien cua tu duy Unity.

## 28. Thoi quen lam viec nen giu lau dai

- Mo Console khi test game.
- Dat ten scene co nghia.
- Kiem tra Inspector truoc khi nghi script bi loi.
- Sap xep lai Project sau moi buoi hoc lon.
- Luu scene truoc va sau khi thu nghiem thay doi lon.

## 29. Goc nhin cua nguoi lam game

- Editor khong chi la noi bam nut.
- Day la noi ban bieu dien cau truc cua game ra thanh hinh.
- Cang quen editor, ban cang de lien ket tu duy code voi the gioi nhin thay.
- Dieu nay rat quan trong khi chuyen sang scripting va debug.

## 30. Cach doc mot scene khi vua mo vao

- Hay nhin `Hierarchy` truoc de biet scene co nhung nhom object nao.
- Tim cac object trung tam nhu `Player`, `Main Camera`, `Canvas`, `GameManager`.
- Sau do chon tung object lon va doc `Inspector`.
- Muc tieu la tra loi nhanh: scene nay dang duoc lap rap theo cach nao.
- Khi lam du an nguoi khac, ky nang doc scene quan trong khong kem ky nang viet code.

## 31. Quy tac dat ten nen dung som

- Ten object nen cho biet vai tro.
- Ten script nen cho biet hanh vi hoac trach nhiem.
- Ten scene nen cho biet man hinh hoac co che.
- Ten thu muc nen cho biet loai tai nguyen.
- Dat ten tot la mot dang documentation song.

## 32. Nen quan sat object theo thu tu nao

1. Object dang nam o dau trong hierarchy?
2. No co parent khong?
3. Transform cua no co hop ly khong?
4. No co nhung component nao?
5. No co dang active khong?
6. Console co bao loi lien quan khong?

## 33. Khi nao can tao scene moi

- Khi muon tach menu va man choi.
- Khi muon co khu vuc test rieng.
- Khi muon co mot scene nho de hoc mot co che.
- Khi scene hien tai qua bon va kho debug.
- Tach scene hop ly giup toc do thu nghiem nhanh hon.

## 34. Scene test la thoi quen tot

- Nguoi moi hay test moi thu trong mot scene duy nhat.
- Cach nay nhanh roi dan tro nen bon.
- Tao scene test cho tung bai hoc se de doi chieu hon.
- Vi du scene test vat ly, scene test input, scene test UI.
- Day la thoi quen rat thuc dung khi du an lon dan.

## 35. Inspector khong chi de nhin

- Day la noi ban chinh so du lieu runtime va edit time.
- Ban co the gan reference bang keo tha.
- Ban co the bat tat component de thu nghiem nhanh.
- Ban co the xem script dang co bien nao mo ra cho designer.
- Hieu Inspector giup ban viet script than thien hon voi editor.

## 36. Khi nao can nghi den prefab

- Khi mot object duoc lap lai nhieu lan.
- Khi ban muon sua mot cho lan ra nhieu noi.
- Khi enemy, coin, bullet, UI panel lap lai trong scene.
- Khi copy thu cong bat dau gay moi met.
- Day la dau hieu prefab se giup viec.

## 37. Console la nguoi ban dong hanh

- Nguoi moi hay so Console vi nhieu dong do.
- Thuc ra day la noi giup ban nhin thay van de som nhat.
- Khi script khong chay, Console thuong la noi co cau tra loi dau tien.
- Khi object bi null, Console cho ten file va dong loi.
- Hinh thanh phan xa mo Console se giup ban tien bo nhanh hon.

## 38. Debug bang editor, khong chi bang code

- Nhin `Inspector` de xem reference co null khong.
- Nhin checkbox active de xem object co bi tat khong.
- Nhin transform de xem object co nam qua xa khong.
- Nhin layer va tag de doan duoc van de tuong tac.
- Nhin camera de xem `Game` vi sao trong khac `Scene`.

## 39. Cac loi editor nhin la biet

- Scene chua luu.
- Object ten mo ho.
- Thu muc `Assets` bon xon.
- Component thieu reference ma van de nguyen.
- Camera chua dat dung goc.
- Console day warning nhung khong ai doc.

## 40. Bai tu quan sat mot scene la

- Hay mo mot scene bat ky trong du an.
- Dung viet code vọi.
- Chi quan sat va tra loi:
- Co bao nhieu nhom object chinh?
- Scene nay co luong quan ly nhu the nao?
- Object nao la logic, object nao la hien thi?
- Day la cach hoc rat tot tu du an co san.

## 41. Editor la cau noi giua code va design

- Lap trinh vien viet script.
- Designer can mot noi de chinh gia tri.
- Editor chinh la noi hai ben gap nhau.
- Vi vay code Unity tot thuong de du lieu hien trong Inspector mot cach co chu dich.
- Hieu editor som se giup ban code de hop tac hon.

## 42. Ky nang nho nhung loi nhat

- Chon dung object truoc khi sua.
- Doc ten object truoc khi doi gia tri.
- Luu scene thuong xuyen.
- Xem Console ngay khi co loi.
- Dat file dung thu muc ngay khi tao.

## 43. Mot ngay lam viec Unity thuong dien ra the nao

- Mo project.
- Mo scene dang lam.
- Kiem tra `Console`.
- Chon object can sua.
- Chinh `Inspector` hoac script.
- Nhan Play de test.
- Quan sat `Game` va `Console`.
- Thoat Play, luu thay doi that su.

## 44. Ky luat editor giup code it loi hon

- Scene gon gang giup tim object nhanh.
- Dat ten tot giup debug reference nhanh.
- Inspector ro rang giup it gan nham.
- Project co thu muc hop ly giup tim asset nhanh.
- Nhung dieu nay khong hao nho, no tac dong truc tiep den nang suat.

## 45. Tong ket bo sung

- Unity Editor khong phai phan phu.
- No la noi to chuc du an, scene va object.
- Nguoi hoc Unity tien bo nhanh la nguoi biet vua doc code vua doc editor.
- Nam vung editor se giup cac bai sau nhe hon rat nhieu.
