##SuperTelegram##

#屎山代码#

1.课程设计，赶出来的项目，美名其曰，进程通信，不如说是基于数据库的通信
2.目前基本可以实现，换个皮肤颜色，好友和群组添加，一对一聊天，记录聊天记录，后续还会实现群组聊天（大概率是三个人的）
3.经不起来过多的测试，没有考虑过多的数据情况，目前数据库很多东西需要手动添加才可以运行
4.只能按照他这个逻辑顺序执行，里面还有很多bug，现在界面控件还没有设计成可以自动调整大小
5.通信方式纯属取巧，不是socket，不是通道，也不是共享内存，只是简单的数据库读写进行通信

#后续#

后续已经完成了群组的通讯，课设还需要完成文件等的传送

#目前找到的问题#

1.不能连续发送相同的信息
2.必须按照顺序打开界面
3.界面动态变化时，控件会出现问题
4.没有经过很多的测试，测试少，只有三个用户
