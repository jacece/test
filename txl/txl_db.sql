/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50719
Source Host           : localhost:3306
Source Database       : txl_db

Target Server Type    : MYSQL
Target Server Version : 50719
File Encoding         : 65001

Date: 2017-11-04 10:10:38
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for txl_msg
-- ----------------------------
DROP TABLE IF EXISTS `txl_msg`;
CREATE TABLE `txl_msg` (
  `class_id` int(11) NOT NULL COMMENT '班级id',
  `msg_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '通知id',
  `content` text NOT NULL COMMENT '通知内容',
  `datetime` datetime DEFAULT NULL COMMENT '时间',
  PRIMARY KEY (`msg_id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of txl_msg
-- ----------------------------
INSERT INTO `txl_msg` VALUES ('1', '1', '同学们，好啊', '2017-11-04 10:09:44');
INSERT INTO `txl_msg` VALUES ('2', '2', '同学们，辛苦了', '2017-11-04 10:09:47');

-- ----------------------------
-- Table structure for txl_user
-- ----------------------------
DROP TABLE IF EXISTS `txl_user`;
CREATE TABLE `txl_user` (
  `name` varchar(64) DEFAULT NULL COMMENT '姓名',
  `tel` varchar(11) DEFAULT NULL,
  `addr` varchar(255) DEFAULT NULL,
  `email` varchar(64) DEFAULT '' COMMENT '密码',
  `wx_no` varchar(18) DEFAULT NULL COMMENT '微信号',
  `qq_no` varchar(18) DEFAULT NULL COMMENT 'qq号码',
  `descript` varchar(255) DEFAULT NULL COMMENT '个人语言',
  `user_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '唯一标识字段',
  `stu_no` varchar(18) DEFAULT NULL COMMENT '学号',
  `pwd` varchar(255) DEFAULT '123456' COMMENT '密码',
  `pic_path` varchar(255) DEFAULT NULL COMMENT '头像路径',
  `level` int(1) DEFAULT '0' COMMENT '权限级别',
  `class_id` int(11) DEFAULT NULL COMMENT '班级id',
  `class_name` varchar(64) DEFAULT NULL COMMENT '班级名称',
  PRIMARY KEY (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=52 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of txl_user
-- ----------------------------
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '1', '031503621', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '2', '031502532', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '3', '031502521', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '4', '031502522', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '5', '031502523', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '6', '031502524', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '7', '031502525', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '8', '031502526', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '9', '031502527', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '10', '031502528', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '11', '031502531', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '12', '031502532', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '13', '031502533', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '14', '031502534', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '15', '031502535', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '16', '031502612', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '17', '031502633', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '18', '031502634', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '19', '031502635', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '20', '031502636', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '21', '031502637', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '22', '031502638', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '23', '031502639', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '24', '031502601', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '25', '031502602', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '26', '031502603', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '27', '031502604', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '28', '031502605', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '29', '031502606', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '30', '031502607', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '31', '031502608', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '32', '031502609', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '33', '031502610', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '34', '031502611', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '35', '031502612', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '36', '031502613', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '37', '031502614', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '38', '031502615', '123456', null, '0', '1', '计算机6班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '39', '031502501', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '40', '031502502', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '41', '031502503', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '42', '031502504', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '43', '031502505', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '44', '031502506', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '45', '031502507', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '46', '031502508', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '47', '031502509', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '48', '031502510', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '49', '031502511', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '50', '031502512', '123456', null, '0', '2', '计算机5班');
INSERT INTO `txl_user` VALUES (null, null, null, '', null, null, null, '51', '031502513', '123456', null, '0', '2', '计算机5班');
