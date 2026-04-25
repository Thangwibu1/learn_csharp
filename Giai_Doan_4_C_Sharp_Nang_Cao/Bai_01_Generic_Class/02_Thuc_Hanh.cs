using System;

class Box<T>
{
    // Bien nay co kieu du lieu la T.
    public T Value;
}

class Program
{
    static void Main(string[] args)
    {
        // Tao box chua int.
        Box<int> scoreBox = new Box<int>();
        scoreBox.Value = 100;

        // Tao box chua string.
        Box<string> nameBox = new Box<string>();
        nameBox.Value = "Knight";

        // In ra gia tri.
        Console.WriteLine(scoreBox.Value);
        Console.WriteLine(nameBox.Value);

        // Goi them cac demo mo rong de thay generic khong chi dung cho mot class don le.
        GenericRepositoryDemo.Run();
        GenericUtilityDemo.Run();
    }
}

class InventoryEntry<T>
{
    public string Label;
    public T Data;

    public InventoryEntry(string label, T data)
    {
        Label = label;
        Data = data;
    }

    public void Print()
    {
        Console.WriteLine(Label + ": " + Data);
    }
}

class SimpleRepository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public void PrintAll(string title)
    {
        Console.WriteLine(title);

        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine("- " + items[i]);
        }
    }
}

static class GenericRepositoryDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Demo repository generic ===");

        SimpleRepository<int> scoreRepository = new SimpleRepository<int>();
        scoreRepository.Add(10);
        scoreRepository.Add(20);
        scoreRepository.Add(30);
        scoreRepository.PrintAll("Danh sach diem:");

        SimpleRepository<string> nameRepository = new SimpleRepository<string>();
        nameRepository.Add("Knight");
        nameRepository.Add("Mage");
        nameRepository.Add("Archer");
        nameRepository.PrintAll("Danh sach ten:");

        InventoryEntry<string> itemEntry = new InventoryEntry<string>("Vat pham", "Potion");
        InventoryEntry<int> goldEntry = new InventoryEntry<int>("Vang", 150);
        itemEntry.Print();
        goldEntry.Print();
    }
}

static class GenericUtilityDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Demo generic method ===");

        int a = 5;
        int b = 9;
        Swap<int>(ref a, ref b);
        Console.WriteLine("Sau khi doi cho int: " + a + ", " + b);

        string left = "Sword";
        string right = "Shield";
        Swap<string>(ref left, ref right);
        Console.WriteLine("Sau khi doi cho string: " + left + ", " + right);

        PrintType<int>(a, "Gia tri a");
        PrintType<string>(left, "Gia tri left");
    }

    public static void Swap<T>(ref T left, ref T right)
    {
        T temp = left;
        left = right;
        right = temp;
    }

    public static void PrintType<T>(T value, string label)
    {
        Console.WriteLine(label + " | Kieu: " + typeof(T).Name + " | Gia tri: " + value);
    }
}

/*
Ghi chu mo rong 001: Generic cho phep viet mot mau class va tai su dung cho nhieu kieu du lieu.
Ghi chu mo rong 002: Khi nhin vao Box<int>, ban biet ngay Value la int.
Ghi chu mo rong 003: Khi nhin vao Box<string>, ban biet ngay Value la string.
Ghi chu mo rong 004: Day la type safety, mot loi ich rat lon cua generic.
Ghi chu mo rong 005: Neu dung object, ban phai ep kieu tay trong nhieu tinh huong.
Ghi chu mo rong 006: Ep kieu tay lam tang nguy co loi runtime.
Ghi chu mo rong 007: Generic giup compiler bat loi som hon.
Ghi chu mo rong 008: Khi lam game, bat loi som tiet kiem nhieu thoi gian debug.
Ghi chu mo rong 009: Generic rat hay xuat hien trong collections cua C#.
Ghi chu mo rong 010: List<T> la vi du quen thuoc nhat.
Ghi chu mo rong 011: Dictionary<TKey, TValue> la vi du quan trong tiep theo.
Ghi chu mo rong 012: Queue<T> va Stack<T> cung dua tren y tuong generic.
Ghi chu mo rong 013: Trong bai nay, Box<T> la vi du toi gian nhat.
Ghi chu mo rong 014: Ban co the mo rong Box<T> thanh nhieu thanh phan hon.
Ghi chu mo rong 015: Vi du, Box<T> co the co method Reset.
Ghi chu mo rong 016: Hoac Box<T> co the co method PrintValue.
Ghi chu mo rong 017: Hoac Box<T> co the co constructor nhan gia tri ban dau.
Ghi chu mo rong 018: Generic khong bi gioi han o class.
Ghi chu mo rong 019: Generic con xuat hien o method.
Ghi chu mo rong 020: Vi du, method Swap<T> co the doi cho hai bien cung kieu.
Ghi chu mo rong 021: Swap<T> dung duoc cho int.
Ghi chu mo rong 022: Swap<T> cung dung duoc cho string.
Ghi chu mo rong 023: Day la suc manh cua tai su dung code.
Ghi chu mo rong 024: Generic cung co the dung voi kieu do nguoi dung tu dinh nghia.
Ghi chu mo rong 025: Vi du PlayerData, ItemData, EnemyData.
Ghi chu mo rong 026: Neu mot logic chi khac nhau o kieu, generic rat dang xem xet.
Ghi chu mo rong 027: Tuy nhien, khong nen dung generic chi de trong co ve cao cap.
Ghi chu mo rong 028: Hay dung no khi bai toan that su can tinh tong quat.
Ghi chu mo rong 029: Ten T la quy uoc pho bien nhung khong bat buoc.
Ghi chu mo rong 030: Ban co the dat ten TKey, TValue, TItem de ro nghia hon.
Ghi chu mo rong 031: Dat ten ro rang lam code de doc hon.
Ghi chu mo rong 032: Trong game, repository generic la mot vi du de thay.
Ghi chu mo rong 033: Mot repository co the luu ItemData.
Ghi chu mo rong 034: Repository khac co the luu QuestData.
Ghi chu mo rong 035: Nhung logic Add va PrintAll co the giong nhau.
Ghi chu mo rong 036: Generic giup khong phai viet lai tung class gan nhu y het.
Ghi chu mo rong 037: Neu khong co generic, code de bi lap lai.
Ghi chu mo rong 038: Lap lai code lam tang chi phi bao tri.
Ghi chu mo rong 039: Sua mot bug o nhieu ban sao cung lam tang rui ro.
Ghi chu mo rong 040: Generic giam bo trung lap do.
Ghi chu mo rong 041: IDE thuong goi y tot hon khi kieu ro rang.
Ghi chu mo rong 042: Autocomplete hoat dong chinh xac hon.
Ghi chu mo rong 043: Review code cung de hon khi nguoi doc thay y do thiet ke ro.
Ghi chu mo rong 044: Generic cung lien quan den hieu nang trong mot so truong hop.
Ghi chu mo rong 045: Dac biet khi so sanh voi object va boxing unboxing.
Ghi chu mo rong 046: Tuy bai nay chua di sau, ban nen biet dieu do ton tai.
Ghi chu mo rong 047: Generic constraint la buoc tiep theo tu nhien.
Ghi chu mo rong 048: Constraint cho phep gioi han T phai thoa mot dieu kien.
Ghi chu mo rong 049: Vi du where T : class.
Ghi chu mo rong 050: Vi du where T : new().
Ghi chu mo rong 051: Vi du where T : IGameData.
Ghi chu mo rong 052: Constraint giup generic vua tong quat vua co gioi han huu ich.
Ghi chu mo rong 053: Khi hoc them, ban se gap generic interface.
Ghi chu mo rong 054: Vi du IRepository<T>.
Ghi chu mo rong 055: Hoac IPool<T>.
Ghi chu mo rong 056: Generic co the ket hop voi inheritance.
Ghi chu mo rong 057: Generic cung ket hop duoc voi delegate.
Ghi chu mo rong 058: Generic cung ket hop duoc voi event.
Ghi chu mo rong 059: Day la ly do no la nen tang rat rong trong C#.
Ghi chu mo rong 060: Khi doc code nguoi khac, thay dau nhon < > la can nghi ngay den generic.
Ghi chu mo rong 061: Tuy nhien, dau nhon cung xuat hien trong so sanh nho hon lon hon.
Ghi chu mo rong 062: Ngu canh se cho ban biet dang la generic hay phep toan.
Ghi chu mo rong 063: Vi du List<int> chac chan la generic.
Ghi chu mo rong 064: Vi du a < b la phep so sanh.
Ghi chu mo rong 065: Kha nang doc cu phap nay se nhanh dan theo thoi gian.
Ghi chu mo rong 066: Thuc hanh la cach tot nhat de quen mat.
Ghi chu mo rong 067: Thu doi Box<T> thanh Holder<T> va xem y nghia co doi khong.
Ghi chu mo rong 068: Thu them method GetValue vao Box<T>.
Ghi chu mo rong 069: Thu them method ReplaceValue vao Box<T>.
Ghi chu mo rong 070: Thu them class Pair<T1, T2> vao file rieng.
Ghi chu mo rong 071: Thu tao Pair<string, int> cho ten stat va gia tri.
Ghi chu mo rong 072: Thu tao Pair<int, string> cho level va rank.
Ghi chu mo rong 073: Generic khien cac mo hinh do de tao hon.
Ghi chu mo rong 074: Ban khong can nhan ban PairStringInt, PairIntString.
Ghi chu mo rong 075: Chi can mot Pair<T1, T2>.
Ghi chu mo rong 076: Cach nghi nay giup codebase gon hon.
Ghi chu mo rong 077: Trong bai nay, comment duoc viet chi tiet de nguoi hoc tu doc file cung hieu.
Ghi chu mo rong 078: Thuc te di lam, comment se tiet che hon neu ten class da tu mo ta ro.
Ghi chu mo rong 079: Hay tap dat ten class va method de giam can comment du thua.
Ghi chu mo rong 080: Nhung khi hoc tap, comment dien giai van rat huu ich.
Ghi chu mo rong 081: Generic giup model hoa y tuong hop chua du lieu.
Ghi chu mo rong 082: Generic giup model hoa repository du lieu.
Ghi chu mo rong 083: Generic giup model hoa object pool.
Ghi chu mo rong 084: Generic giup model hoa event bus.
Ghi chu mo rong 085: Generic giup model hoa cache.
Ghi chu mo rong 086: Tat ca deu rat hop voi game.
Ghi chu mo rong 087: Game thuong co nhieu doi tuong khac nhau nhung chia se logic chung.
Ghi chu mo rong 088: Day la moi truong ly tuong de generic phat huy tac dung.
Ghi chu mo rong 089: Hay luon tu hoi logic nao dang bi lap.
Ghi chu mo rong 090: Hay luon tu hoi phan khac nhau chi la kieu du lieu hay con logic khac nua.
Ghi chu mo rong 091: Neu chi la kieu du lieu, generic la ung vien sang gia.
Ghi chu mo rong 092: Neu logic cung khac biet sau sac, co the generic khong phai lua chon tot nhat.
Ghi chu mo rong 093: Day la ky nang thiet ke can ren luyen.
Ghi chu mo rong 094: Khong co quy tac may moc cho moi tinh huong.
Ghi chu mo rong 095: Nhung generic la cong cu rat manh.
Ghi chu mo rong 096: Moi lan gap List<T>, hay nho rang no chi la mot generic class rat thanh cong.
Ghi chu mo rong 097: Moi lan gap Dictionary<TKey, TValue>, hay nho rang thu vien C# dang day ban bang vi du that.
Ghi chu mo rong 098: Ban dang dung generic moi ngay du chua de y.
Ghi chu mo rong 099: Muc tieu cua bai nay la bien dieu quen thuoc do thanh kien thuc co y thuc.
Ghi chu mo rong 100: Khi da co y thuc, ban se biet luc nao can tu tao generic class cho rieng minh.
Ghi chu mo rong 101: Bai tap tiep theo nen huong den inventory, repository va cache nho.
Ghi chu mo rong 102: Day la nhung bai toan rat gan game.
Ghi chu mo rong 103: Ban co the thu viet RewardBox<T> cho he thong phan thuong.
Ghi chu mo rong 104: Ban co the thu viet SaveSlot<T> cho du lieu luu game.
Ghi chu mo rong 105: Ban co the thu viet ConfigEntry<T> cho cau hinh game.
Ghi chu mo rong 106: Moi bai nho nhu vay se lam generic de tham hon.
Ghi chu mo rong 107: Dung ngai viet nhieu ban demo nho.
Ghi chu mo rong 108: Hoc nguyen ly thong qua vi du la cach rat hieu qua.
Ghi chu mo rong 109: Cang nhieu kieu du lieu duoc thu, ban cang thay generic linh hoat.
Ghi chu mo rong 110: Thu voi bool, float, string, class tu tao.
Ghi chu mo rong 111: Thu voi object de so sanh trai nghiem dung generic va khong dung generic.
Ghi chu mo rong 112: Tu dat cau hoi trong luc hoc se giup nho lau hon.
Ghi chu mo rong 113: Vi du, tai sao Box<object> khac Box<int>.
Ghi chu mo rong 114: Vi du, tai sao compiler khong cho gan string vao Box<int>.
Ghi chu mo rong 115: Vi du, tai sao Swap<T> khong can biet T la gi ma van doi duoc.
Ghi chu mo rong 116: Cau tra loi nam o cho code duoc viet theo mau tong quat.
Ghi chu mo rong 117: Mau do duoc compiler chuyen thanh phien ban phu hop khi su dung.
Ghi chu mo rong 118: Tu duy mau tong quat rat quan trong trong lap trinh.
Ghi chu mo rong 119: Generic la mot cach bieu dat tu duy do.
Ghi chu mo rong 120: Hay quay lai file ly thuyet neu ban can goc nhin tong quan hon.
Ghi chu mo rong 121: Sau do quay lai file thuc hanh de thu sua code.
Ghi chu mo rong 122: Hoc lap trinh hieu qua nhat la doc, sua, chay, va quan sat.
Ghi chu mo rong 123: Dung chi doc thu dong.
Ghi chu mo rong 124: Hay chu dong bien doi gia tri, doi ten, them kieu moi.
Ghi chu mo rong 125: Moi lan sua nho la mot lan hieu them.
Ghi chu mo rong 126: Box<int> co the dung cho diem so.
Ghi chu mo rong 127: Box<string> co the dung cho ten nhan vat.
Ghi chu mo rong 128: Box<float> co the dung cho toc do.
Ghi chu mo rong 129: Box<bool> co the dung cho trang thai khoa mo.
Ghi chu mo rong 130: Box<PlayerData> co the dung cho du lieu nguoi choi.
Ghi chu mo rong 131: Day la nhieu cach dung tren cung mot khuon class.
Ghi chu mo rong 132: Va do la y nghia cot loi cua generic class.
Ghi chu mo rong 133: Neu ban quen, hay nho cum tu mot khuon cho nhieu kieu.
Ghi chu mo rong 134: Day la cach nho ngan gon nhat.
Ghi chu mo rong 135: Nhung dung quen phan safety.
Ghi chu mo rong 136: Neu chi la mot khuon ma khong an toan kieu thi object cung lam duoc.
Ghi chu mo rong 137: Suc manh cua generic la vua tong quat vua an toan hon.
Ghi chu mo rong 138: Day la diem phan biet lon.
Ghi chu mo rong 139: O cap do beginner, hieu den day da rat tot.
Ghi chu mo rong 140: O cap do cao hon, ban se hoc variance va generic interfaces phuc tap hon.
Ghi chu mo rong 141: Luc nay chua can vo vang.
Ghi chu mo rong 142: Nen vung mot generic class don gian truoc.
Ghi chu mo rong 143: Nen vung generic method don gian tiep theo.
Ghi chu mo rong 144: Nen vung cach doc collections generic hang ngay.
Ghi chu mo rong 145: Sau do moi mo rong tiep.
Ghi chu mo rong 146: Kien thuc nen tang vung se giup hoc nhanh hon ve sau.
Ghi chu mo rong 147: Trong code game, tinh ro rang quan trong khong kem tinh thong minh.
Ghi chu mo rong 148: Generic dung dung cho code vua gon vua ro.
Ghi chu mo rong 149: Generic dung sai co the lam code kho doc vi qua truu tuong.
Ghi chu mo rong 150: Vi vay hay can bang giua tong quat va de hieu.
Ghi chu mo rong 151: Neu chi co mot truong hop su dung duy nhat va kho mo rong, co the chua can generic.
Ghi chu mo rong 152: Neu thay pattern lap lai ro, generic rat dang can nhac.
Ghi chu mo rong 153: Day la ky nang phan tich bai toan.
Ghi chu mo rong 154: Ky nang nay quan trong hon viec hoc thuoc syntax.
Ghi chu mo rong 155: File nay da them nhieu dong ghi chu de ban co the on tap ngay trong code.
Ghi chu mo rong 156: Ban co the xoa bot comment sau khi da hieu.
Ghi chu mo rong 157: Va giu lai phan code cot loi gan gon hon.
Ghi chu mo rong 158: Day cung la mot bai hoc ve viec code hoc tap khac code san pham.
Ghi chu mo rong 159: Code hoc tap can de doc, de doi chieu, de thay y tuong.
Ghi chu mo rong 160: Code san pham can gon, ro, bao tri tot.
Ghi chu mo rong 161: Hai muc tieu nay gan nhau nhung khong hoan toan trung.
Ghi chu mo rong 162: Biet minh dang viet cho muc dich nao la rat quan trong.
Ghi chu mo rong 163: O day, muc dich la hoc.
Ghi chu mo rong 164: Vi vay comment duoc mo rong nhieu hon.
Ghi chu mo rong 165: Khi tu viet lai, hay thu rut gon ma van giu du y nghia.
Ghi chu mo rong 166: Do la cach kiem tra xem ban da hieu that chua.
Ghi chu mo rong 167: Neu ban rut gon duoc, nghia la ban da nam logic.
Ghi chu mo rong 168: Neu ban chi chep lai ma khong rut gon duoc, co the ban chua hieu sau.
Ghi chu mo rong 169: Tu hoc lap trinh can su trung thuc voi chinh minh.
Ghi chu mo rong 170: Khong sao neu chua hieu ngay lan dau.
Ghi chu mo rong 171: Generic la chu de ma rat nhieu nguoi can nhieu lan moi that su tham.
Ghi chu mo rong 172: Dieu do hoan toan binh thuong.
Ghi chu mo rong 173: Hay tiep tuc lam bai tap nho.
Ghi chu mo rong 174: Moi bai se boi dap mot chut truc giac.
Ghi chu mo rong 175: Den mot luc, ban se thay no rat tu nhien.
Ghi chu mo rong 176: Khi do, viec thiet ke class tong quat se de dang hon.
Ghi chu mo rong 177: Ban se bat dau nhin thay pattern trong code.
Ghi chu mo rong 178: Va day la mot buoc truong thanh trong tu duy lap trinh.
Ghi chu mo rong 179: Generic khong chi la syntax.
Ghi chu mo rong 180: Generic la cach nghi ve su lap lai va tinh tong quat.
Ghi chu mo rong 181: Hay ghi nho dieu nay.
Ghi chu mo rong 182: Khi can, quay lai file nay de doc lai cac demo.
Ghi chu mo rong 183: Co the chinh sua demo de phu hop bai toan cua rieng ban.
Ghi chu mo rong 184: Vi du inventory item, quest objective, wave config.
Ghi chu mo rong 185: Cac chu de do deu hop voi generic.
Ghi chu mo rong 186: Thuc hanh lap lai se giup nho lau hon doc ly thuyet don thuan.
Ghi chu mo rong 187: Neu co the, hay tu viet mot file moi khong nhin lai file nay.
Ghi chu mo rong 188: Sau do so sanh voi file nay.
Ghi chu mo rong 189: Cach hoc chu dong nay rat hieu qua.
Ghi chu mo rong 190: Ban co the giai thich generic cho nguoi khac khong.
Ghi chu mo rong 191: Neu co, nghia la ban da nam kha chac.
Ghi chu mo rong 192: Neu chua, hay thu dung vi du hop chua do vat de tu giai thich.
Ghi chu mo rong 193: Hinh anh doi thuong giup nho kha tot.
Ghi chu mo rong 194: T la nhan dan tren hop, co the thay bang bat ky loai nao hop le.
Ghi chu mo rong 195: Con Box<T> la thiet ke cua hop.
Ghi chu mo rong 196: Cung mot thiet ke, nhieu cach dung.
Ghi chu mo rong 197: Day la cau chot cua bai.
Ghi chu mo rong 198: Sau khi nam generic, ban se de tiep can collections hon.
Ghi chu mo rong 199: Va day la cau noi sang bai collections trong game.
Ghi chu mo rong 200: Ket thuc phan ghi chu mo rong cho file thuc hanh generic.
Ghi chu mo rong 201: Ban co the bo sung them 10 demo nua neu muon tu luyen.
Ghi chu mo rong 202: Vi du tao class Reward<T> de luu phan thuong bat ky.
Ghi chu mo rong 203: Vi du tao class DataNode<T> de luu mot gia tri trong cay du lieu.
Ghi chu mo rong 204: Vi du tao class SettingValue<T> cho system setting.
Ghi chu mo rong 205: Moi vi du se lam generic gan thuc te hon.
Ghi chu mo rong 206: Dung quen dat ten class theo y nghia nghiep vu.
Ghi chu mo rong 207: Generic khong thay the cho viec dat ten tot.
Ghi chu mo rong 208: Generic chi giup tai su dung va an toan kieu.
Ghi chu mo rong 209: Ten class van phai truyen tai muc dich.
Ghi chu mo rong 210: InventoryEntry<T> nghe ro hon Entry<T> trong nhieu boi canh game.
Ghi chu mo rong 211: SimpleRepository<T> nghe ro hon DataThing<T>.
Ghi chu mo rong 212: Day la ky nang clean code can song hanh voi generic.
Ghi chu mo rong 213: Hay tap doc ten va tu hoi ten co tu mo ta du y do chua.
Ghi chu mo rong 214: Neu ten mo ho, nguoi doc se can comment nhieu hon.
Ghi chu mo rong 215: Neu ten ro, comment chi can bo sung nhung cho that can thiet.
Ghi chu mo rong 216: Cuoi cung, hay chay file sau moi lan sua de tu xac nhan hieu cua minh.
Ghi chu mo rong 217: Kien thuc that su vung khi ban vua doc duoc vua sua duoc.
Ghi chu mo rong 218: Va quan trong hon, ban co the tu tao vi du moi.
Ghi chu mo rong 219: Khi da lam duoc dieu do, generic da tro thanh cong cu cua ban.
Ghi chu mo rong 220: Het.
*/
