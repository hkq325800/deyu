/*
Navicat MySQL Data Transfer

Source Server         : wc
Source Server Version : 50096
Source Host           : localhost:3306
Source Database       : hdu_sce

Target Server Type    : MYSQL
Target Server Version : 50096
File Encoding         : 65001

Date: 2013-11-17 17:00:39
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `t_cosler`
-- ----------------------------
DROP TABLE IF EXISTS `t_cosler`;
CREATE TABLE `t_cosler` (
  `f_PY` char(1) NOT NULL,
  `cBegin` smallint(5) unsigned NOT NULL,
  `cEnd` smallint(5) unsigned NOT NULL,
  PRIMARY KEY  (`f_PY`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of t_cosler
-- ----------------------------
INSERT INTO `t_cosler` VALUES ('A', '45217', '45252');
INSERT INTO `t_cosler` VALUES ('B', '45253', '45760');
INSERT INTO `t_cosler` VALUES ('c', '45761', '46317');
INSERT INTO `t_cosler` VALUES ('D', '46318', '46825');
INSERT INTO `t_cosler` VALUES ('E', '46826', '47009');
INSERT INTO `t_cosler` VALUES ('F', '47010', '47296');
INSERT INTO `t_cosler` VALUES ('G', '47297', '47613');
INSERT INTO `t_cosler` VALUES ('H', '47614', '48118');
INSERT INTO `t_cosler` VALUES ('J', '48119', '49061');
INSERT INTO `t_cosler` VALUES ('K', '49062', '49323');
INSERT INTO `t_cosler` VALUES ('L', '49324', '49895');
INSERT INTO `t_cosler` VALUES ('M', '49896', '50370');
INSERT INTO `t_cosler` VALUES ('N', '50371', '50613');
INSERT INTO `t_cosler` VALUES ('O', '50614', '50621');
INSERT INTO `t_cosler` VALUES ('P', '50622', '50905');
INSERT INTO `t_cosler` VALUES ('Q', '50906', '51386');
INSERT INTO `t_cosler` VALUES ('R', '51387', '51445');
INSERT INTO `t_cosler` VALUES ('S', '51446', '52217');
INSERT INTO `t_cosler` VALUES ('T', '52218', '52697');
INSERT INTO `t_cosler` VALUES ('W', '52698', '52979');
INSERT INTO `t_cosler` VALUES ('X', '52980', '53640');
INSERT INTO `t_cosler` VALUES ('Y', '53689', '54480');
INSERT INTO `t_cosler` VALUES ('Z', '54481', '55289');
