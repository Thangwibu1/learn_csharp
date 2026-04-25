# Bài 1: MonoBehaviour

## Mục tiêu

- Hiểu `MonoBehaviour` là gì
- Biết `Start`, `Update`, `Awake`

## `MonoBehaviour` là gì?

Đây là class nền tảng để script của bạn gắn vào GameObject trong Unity.

## Hàm thường gặp

- `Awake()`: khởi tạo sớm
- `Start()`: chạy khi bắt đầu
- `Update()`: chạy mỗi frame

## Tại sao phải dùng cái này?

Vì gần như mọi script Unity cơ bản đều đi qua `MonoBehaviour`.

## Lỗi sai thường gặp của người mới

- Nhồi quá nhiều việc vào `Update()`
- Không hiểu thứ tự `Awake` và `Start`
