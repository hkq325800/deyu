/*
Navicat MySQL Data Transfer

Source Server         : MySQL
Source Server Version : 50067
Source Host           : localhost:3306
Source Database       : hdu_sce

Target Server Type    : MYSQL
Target Server Version : 50067
File Encoding         : 65001

Date: 2013-10-18 11:42:48
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `category`
-- ----------------------------
DROP TABLE IF EXISTS `category`;
CREATE TABLE `category` (
  `ca_id` int(11) NOT NULL auto_increment COMMENT '类别ID',
  `co_id` int(11) NOT NULL COMMENT '学院ID',
  `ca_name` varchar(50) NOT NULL COMMENT '类别名称',
  `ca_basic` int(11) NOT NULL COMMENT '基准分',
  `ca_weight` decimal(2,2) NOT NULL COMMENT 'ca_weight',
  PRIMARY KEY  (`ca_id`),
  KEY `fk_cam_ca` (`co_id`),
  CONSTRAINT `fk_ca_co` FOREIGN KEY (`co_id`) REFERENCES `college` (`co_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of category
-- ----------------------------
INSERT INTO `category` VALUES ('1', '1', '德育测评', '70', '0.20');
INSERT INTO `category` VALUES ('2', '1', '技能测评', '70', '0.15');
INSERT INTO `category` VALUES ('3', '1', '体育测评', '75', '0.05');

-- ----------------------------
-- Table structure for `class`
-- ----------------------------
DROP TABLE IF EXISTS `class`;
CREATE TABLE `class` (
  `cl_id` int(11) NOT NULL auto_increment COMMENT '班级id',
  `cl_name` varchar(8) NOT NULL COMMENT '班级名',
  `pr_id` int(11) NOT NULL COMMENT '所属专业',
  `cl_grade` int(4) NOT NULL,
  PRIMARY KEY  (`cl_id`),
  UNIQUE KEY `cl_name` (`cl_name`),
  KEY `fk_cl_pr` (`pr_id`),
  CONSTRAINT `fk_cl_pr` FOREIGN KEY (`pr_id`) REFERENCES `profession` (`pr_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of class
-- ----------------------------
INSERT INTO `class` VALUES ('1', '10108416', '5', '2010');
INSERT INTO `class` VALUES ('2', '10108415', '2', '2012');
INSERT INTO `class` VALUES ('3', '11108415', '2', '2011');

-- ----------------------------
-- Table structure for `classmanage`
-- ----------------------------
DROP TABLE IF EXISTS `classmanage`;
CREATE TABLE `classmanage` (
  `cl_id` int(11) NOT NULL COMMENT '班级id',
  `us_id` int(11) NOT NULL COMMENT '工号',
  PRIMARY KEY  (`cl_id`,`us_id`),
  KEY `pfk_clm_us` (`us_id`),
  CONSTRAINT `pfk_clm_cl` FOREIGN KEY (`cl_id`) REFERENCES `class` (`cl_id`),
  CONSTRAINT `pfk_clm_ma` FOREIGN KEY (`us_id`) REFERENCES `manager` (`us_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of classmanage
-- ----------------------------
INSERT INTO `classmanage` VALUES ('1', '54');
INSERT INTO `classmanage` VALUES ('2', '54');
INSERT INTO `classmanage` VALUES ('3', '54');

-- ----------------------------
-- Table structure for `college`
-- ----------------------------
DROP TABLE IF EXISTS `college`;
CREATE TABLE `college` (
  `co_id` int(11) NOT NULL auto_increment COMMENT '学院表',
  `co_name` varchar(50) NOT NULL COMMENT '学院名称',
  `co_document` varchar(255) default NULL COMMENT '项目文档文件路径',
  PRIMARY KEY  (`co_id`),
  UNIQUE KEY `co_name` (`co_name`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of college
-- ----------------------------
INSERT INTO `college` VALUES ('1', '软件工程学院', null);

-- ----------------------------
-- Table structure for `dictionary`
-- ----------------------------
DROP TABLE IF EXISTS `dictionary`;
CREATE TABLE `dictionary` (
  `dic_id` int(11) NOT NULL default '0' COMMENT '字典ID',
  `dic_value` varchar(255) default NULL COMMENT '字典名称',
  PRIMARY KEY  (`dic_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of dictionary
-- ----------------------------
INSERT INTO `dictionary` VALUES ('1', '加');
INSERT INTO `dictionary` VALUES ('2', '减');
INSERT INTO `dictionary` VALUES ('1001', '超级管理员');
INSERT INTO `dictionary` VALUES ('1002', '普通管理员');
INSERT INTO `dictionary` VALUES ('1003', '学生');
INSERT INTO `dictionary` VALUES ('2001', '未知');
INSERT INTO `dictionary` VALUES ('2002', '男');
INSERT INTO `dictionary` VALUES ('2003', '女');
INSERT INTO `dictionary` VALUES ('3001', '正常');
INSERT INTO `dictionary` VALUES ('3002', '禁用');

-- ----------------------------
-- Table structure for `item`
-- ----------------------------
DROP TABLE IF EXISTS `item`;
CREATE TABLE `item` (
  `it_id` int(11) NOT NULL auto_increment COMMENT '常用项ID',
  `ca_id` int(11) NOT NULL COMMENT '类别ID',
  `it_name` varchar(50) NOT NULL COMMENT '常用项名称',
  `it_score` decimal(4,1) NOT NULL COMMENT '常用项分值',
  `it_reason` varchar(255) NOT NULL COMMENT '常用项原因',
  PRIMARY KEY  (`it_id`),
  KEY `fk_mes_cam` (`ca_id`),
  CONSTRAINT `fk_it_ca` FOREIGN KEY (`ca_id`) REFERENCES `category` (`ca_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of item
-- ----------------------------
INSERT INTO `item` VALUES ('3', '1', '加加加', '3.5', '随便加');
INSERT INTO `item` VALUES ('4', '1', '拉拉<\'\">^%#&', '4.0', '拉拉<\'\">^%#&');

-- ----------------------------
-- Table structure for `manager`
-- ----------------------------
DROP TABLE IF EXISTS `manager`;
CREATE TABLE `manager` (
  `us_id` int(11) NOT NULL COMMENT '工号',
  `ma_state` int(11) NOT NULL default '3001' COMMENT '管理员状态',
  `co_id` int(11) NOT NULL COMMENT '学院',
  PRIMARY KEY  (`us_id`),
  KEY `pfk_ma_ca` (`co_id`),
  KEY `fk_state_dic` (`ma_state`),
  CONSTRAINT `fk_ma_ca` FOREIGN KEY (`co_id`) REFERENCES `college` (`co_id`),
  CONSTRAINT `fk_state_dic` FOREIGN KEY (`ma_state`) REFERENCES `dictionary` (`dic_id`),
  CONSTRAINT `pfk_ma_us` FOREIGN KEY (`us_id`) REFERENCES `user` (`us_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of manager
-- ----------------------------
INSERT INTO `manager` VALUES ('52', '3001', '1');
INSERT INTO `manager` VALUES ('53', '3001', '1');
INSERT INTO `manager` VALUES ('54', '3001', '1');
INSERT INTO `manager` VALUES ('55', '3002', '1');
INSERT INTO `manager` VALUES ('56', '3001', '1');
INSERT INTO `manager` VALUES ('57', '3001', '1');
INSERT INTO `manager` VALUES ('58', '3001', '1');
INSERT INTO `manager` VALUES ('59', '3001', '1');
INSERT INTO `manager` VALUES ('60', '3001', '1');
INSERT INTO `manager` VALUES ('61', '3001', '1');
INSERT INTO `manager` VALUES ('62', '3001', '1');
INSERT INTO `manager` VALUES ('63', '3001', '1');
INSERT INTO `manager` VALUES ('64', '3001', '1');
INSERT INTO `manager` VALUES ('65', '3001', '1');
INSERT INTO `manager` VALUES ('66', '3001', '1');
INSERT INTO `manager` VALUES ('67', '3001', '1');
INSERT INTO `manager` VALUES ('68', '3001', '1');
INSERT INTO `manager` VALUES ('69', '3001', '1');
INSERT INTO `manager` VALUES ('70', '3001', '1');
INSERT INTO `manager` VALUES ('71', '3001', '1');
INSERT INTO `manager` VALUES ('72', '3001', '1');
INSERT INTO `manager` VALUES ('74', '3001', '1');
INSERT INTO `manager` VALUES ('75', '3001', '1');
INSERT INTO `manager` VALUES ('76', '3001', '1');

-- ----------------------------
-- Table structure for `operate`
-- ----------------------------
DROP TABLE IF EXISTS `operate`;
CREATE TABLE `operate` (
  `op_id` int(11) NOT NULL auto_increment COMMENT '操作ID',
  `ca_id` int(11) NOT NULL COMMENT '类别ID',
  `it_date` date NOT NULL COMMENT '项目时间 与操作时间无关',
  `it_score` decimal(3,1) NOT NULL COMMENT '分值',
  `it_reason` varchar(200) NOT NULL COMMENT '理由',
  `op_usid` int(11) NOT NULL COMMENT '操作人',
  `op_time` datetime NOT NULL COMMENT '操作时间',
  PRIMARY KEY  (`op_id`),
  KEY `fk_meo_cam` (`ca_id`),
  KEY `fk_op_ma` (`op_usid`),
  CONSTRAINT `fk_op_ca` FOREIGN KEY (`ca_id`) REFERENCES `category` (`ca_id`),
  CONSTRAINT `fk_op_ma` FOREIGN KEY (`op_usid`) REFERENCES `manager` (`us_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of operate
-- ----------------------------
INSERT INTO `operate` VALUES ('1', '1', '2013-10-15', '2.0', 'asdf', '52', '2013-10-15 14:43:01');
INSERT INTO `operate` VALUES ('2', '1', '2013-10-15', '3.0', 'sfs', '53', '2013-10-15 15:18:52');
INSERT INTO `operate` VALUES ('3', '2', '2013-10-15', '4.0', 'dsfg', '52', '2013-10-15 16:39:20');
INSERT INTO `operate` VALUES ('4', '1', '2013-10-17', '3.5', '随便加', '52', '2013-10-18 00:10:06');
INSERT INTO `operate` VALUES ('5', '1', '2013-10-18', '4.0', '拉拉<\'\">^%#&', '52', '2013-10-18 00:10:52');

-- ----------------------------
-- Table structure for `profession`
-- ----------------------------
DROP TABLE IF EXISTS `profession`;
CREATE TABLE `profession` (
  `pr_id` int(11) NOT NULL auto_increment COMMENT '专业ID',
  `pr_name` varchar(50) NOT NULL COMMENT '专业名称',
  `co_id` int(11) NOT NULL COMMENT '所属学院',
  PRIMARY KEY  (`pr_id`),
  UNIQUE KEY `pr_name` (`pr_name`),
  KEY `pfk_pr_ca` (`co_id`),
  CONSTRAINT `fk_pr_co` FOREIGN KEY (`co_id`) REFERENCES `college` (`co_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of profession
-- ----------------------------
INSERT INTO `profession` VALUES ('2', '软件工程专业', '1');
INSERT INTO `profession` VALUES ('5', '计算机科学与技术(专升本)', '1');

-- ----------------------------
-- Table structure for `rate`
-- ----------------------------
DROP TABLE IF EXISTS `rate`;
CREATE TABLE `rate` (
  `ra_id` int(11) NOT NULL auto_increment,
  `ca_id` int(11) NOT NULL,
  `ra_start` int(11) NOT NULL,
  `ra_end` int(11) default NULL,
  `ra_percentage` int(2) NOT NULL,
  PRIMARY KEY  (`ra_id`),
  KEY `fk_ra_ca` (`ca_id`),
  CONSTRAINT `fk_ra_ca` FOREIGN KEY (`ca_id`) REFERENCES `category` (`ca_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of rate
-- ----------------------------
INSERT INTO `rate` VALUES ('1', '1', '100', '110', '50');
INSERT INTO `rate` VALUES ('2', '1', '110', null, '30');
INSERT INTO `rate` VALUES ('3', '2', '100', '110', '50');
INSERT INTO `rate` VALUES ('4', '2', '110', null, '30');
INSERT INTO `rate` VALUES ('7', '3', '100', '110', '50');
INSERT INTO `rate` VALUES ('8', '3', '110', null, '30');

-- ----------------------------
-- Table structure for `semester`
-- ----------------------------
DROP TABLE IF EXISTS `semester`;
CREATE TABLE `semester` (
  `se_id` int(11) NOT NULL auto_increment COMMENT '学期ID',
  `co_id` int(11) NOT NULL COMMENT '学院ID',
  `se_year` int(4) NOT NULL COMMENT '学年',
  `se_term` int(1) NOT NULL COMMENT '学期',
  `se_start` date NOT NULL COMMENT '起始日期',
  `se_end` date NOT NULL,
  PRIMARY KEY  (`se_id`),
  UNIQUE KEY `se_year_term` (`se_year`,`se_term`),
  KEY `fk_te_ca` (`co_id`),
  CONSTRAINT `fk_se_co` FOREIGN KEY (`co_id`) REFERENCES `college` (`co_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of semester
-- ----------------------------
INSERT INTO `semester` VALUES ('2', '1', '2010', '1', '2010-09-01', '2011-01-14');
INSERT INTO `semester` VALUES ('3', '1', '2013', '1', '2013-09-01', '2014-01-23');

-- ----------------------------
-- Table structure for `student`
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student` (
  `us_id` int(11) NOT NULL COMMENT '学号',
  `cl_id` int(11) NOT NULL COMMENT '班级',
  `st_job` varchar(30) default NULL COMMENT '职务',
  `st_part` varchar(30) default NULL COMMENT '党员',
  `st_dormitory` varchar(30) default NULL COMMENT '寝室',
  PRIMARY KEY  (`us_id`),
  KEY `pfk_st_cl` (`cl_id`),
  CONSTRAINT `fk_st_cl` FOREIGN KEY (`cl_id`) REFERENCES `class` (`cl_id`),
  CONSTRAINT `pfk_st_us` FOREIGN KEY (`us_id`) REFERENCES `user` (`us_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES ('1', '2', null, null, null);
INSERT INTO `student` VALUES ('10', '3', '寝室长', '预备党员', null);

-- ----------------------------
-- Table structure for `studentoperate`
-- ----------------------------
DROP TABLE IF EXISTS `studentoperate`;
CREATE TABLE `studentoperate` (
  `us_id` int(11) NOT NULL default '0',
  `op_id` int(11) NOT NULL default '0',
  PRIMARY KEY  (`us_id`,`op_id`),
  KEY `pfk_so_op` (`op_id`),
  CONSTRAINT `pfk_so_op` FOREIGN KEY (`op_id`) REFERENCES `operate` (`op_id`),
  CONSTRAINT `pfk_so_st` FOREIGN KEY (`us_id`) REFERENCES `student` (`us_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of studentoperate
-- ----------------------------
INSERT INTO `studentoperate` VALUES ('1', '1');
INSERT INTO `studentoperate` VALUES ('1', '2');
INSERT INTO `studentoperate` VALUES ('1', '3');
INSERT INTO `studentoperate` VALUES ('1', '4');
INSERT INTO `studentoperate` VALUES ('1', '5');

-- ----------------------------
-- Table structure for `user`
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `us_id` int(11) NOT NULL auto_increment COMMENT '用户ID',
  `us_number` varchar(30) default NULL COMMENT '学号/工号',
  `us_password` varchar(32) NOT NULL COMMENT '用户密码',
  `us_rank` int(11) NOT NULL COMMENT '权限级别',
  `us_name` varchar(20) NOT NULL COMMENT '名字',
  `us_sex` int(11) NOT NULL COMMENT '性别',
  `us_tel` varchar(30) default NULL COMMENT '电话',
  `us_email` varchar(50) default NULL COMMENT '邮箱',
  PRIMARY KEY  (`us_id`),
  UNIQUE KEY `us_number` (`us_number`),
  KEY `fk_rank_dic` (`us_rank`),
  KEY `fk_sex_dic` (`us_sex`),
  CONSTRAINT `fk_rank_dic` FOREIGN KEY (`us_rank`) REFERENCES `dictionary` (`dic_id`),
  CONSTRAINT `fk_sex_dic` FOREIGN KEY (`us_sex`) REFERENCES `dictionary` (`dic_id`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', '10109235', 'd49e8336de48ac9805c8ae7b1086dee2', '1003', '阿三', '2001', '18767135648', null);
INSERT INTO `user` VALUES ('3', '10109295', '912ec803b2ce49e4a541068d495ab570', '1003', 'asdf', '2001', null, null);
INSERT INTO `user` VALUES ('4', null, '123', '1003', 'ffd', '2001', null, null);
INSERT INTO `user` VALUES ('5', null, 'sdfgsdfg', '1003', 'df', '2001', null, null);
INSERT INTO `user` VALUES ('6', '108', 'sdfgsdfg', '1003', '108', '2001', null, null);
INSERT INTO `user` VALUES ('7', '109', 'sdfgsdfg', '1003', '109', '2001', null, null);
INSERT INTO `user` VALUES ('9', '12106102', '6604886226f7c0d4591326e58cc4e6e6', '1003', '陈霞', '2002', '13567166800', null);
INSERT INTO `user` VALUES ('10', '12106103', 'd3c59ab8742e664c9a30523c969508e2', '1003', '陈杨丽', '2001', '13738090251', null);
INSERT INTO `user` VALUES ('52', 'admin', '21232f297a57a5a743894a0e4a801fc3', '1001', 'adminnn', '2001', null, null);
INSERT INTO `user` VALUES ('53', null, '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('54', 'admin1', 'e00cf25ad42683b3df678c61f42c6bda', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('55', 'admin10', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('56', 'admin11', '21232f297a57a5a743894a0e4a801fc3', '1002', '阿三', '2001', null, null);
INSERT INTO `user` VALUES ('57', 'admin12', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('58', null, '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('59', null, '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('60', null, '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('61', 'admin16', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('62', 'admin171', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('63', 'admin18', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('64', 'admin19', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('65', 'admin2', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('66', 'admin3', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('67', 'admin4', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('68', 'admin5', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('69', 'admin6', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('70', 'admin7', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('71', 'admin8', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('72', 'admin9', '21232f297a57a5a743894a0e4a801fc3', '1002', 'admin', '2001', null, null);
INSERT INTO `user` VALUES ('73', 'dfg5', 'sdfgsdfg', '1003', 'dfg5', '2001', null, null);
INSERT INTO `user` VALUES ('74', null, '47bce5c74f589f4867dbd57e9ca9f808', '1001', 'aaa', '2001', null, null);
INSERT INTO `user` VALUES ('75', 'admin123', '0192023a7bbd73250516f069df18b500', '1001', '撒', '2003', null, null);
INSERT INTO `user` VALUES ('76', 'asd', '7815696ecbf1c96e6894b779456d330e', '1001', 'fda', '2001', null, null);
