<?php
namespace app\index\controller;
use think\Db;
class Play
{
    public function play()
    {
        $data = Db::table('person')->where(123)->find();
        return $data;
    }
}
