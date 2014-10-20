/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50096
Source Host           : localhost:3306
Source Database       : hdu_sce

Target Server Type    : MYSQL
Target Server Version : 50096
File Encoding         : 65001

Date: 2014-10-20 11:19:06
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for category
-- ----------------------------
DROP TABLE IF EXISTS `category`;
CREATE TABLE `category` (
  `ca_id` int(11) NOT NULL auto_increment COMMENT '类别ID',
  `co_id` int(11) NOT NULL COMMENT '学院ID',
  `ca_name` varchar(50) NOT NULL COMMENT '类别名称',
  `ca_basic` int(11) NOT NULL COMMENT '基准分',
  `ca_weight` decimal(2,2) NOT NULL COMMENT 'ca_weight',
  `ca_start_year` int(11) NOT NULL,
  `ca_start_term` int(1) NOT NULL,
  `ca_end_year` int(11) NOT NULL,
  `ca_end_term` int(1) default NULL,
  PRIMARY KEY  (`ca_id`),
  KEY `fk_cam_ca` (`co_id`),
  CONSTRAINT `fk_ca_co` FOREIGN KEY (`co_id`) REFERENCES `college` (`co_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Table structure for class
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
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Table structure for classmanage
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
-- Table structure for college
-- ----------------------------
DROP TABLE IF EXISTS `college`;
CREATE TABLE `college` (
  `co_id` int(11) NOT NULL auto_increment COMMENT '学院表',
  `co_name` varchar(50) NOT NULL COMMENT '学院名称',
  `co_document` varchar(255) default NULL COMMENT '项目文档文件路径',
  PRIMARY KEY  (`co_id`),
  UNIQUE KEY `co_name` (`co_name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Table structure for dictionary
-- ----------------------------
DROP TABLE IF EXISTS `dictionary`;
CREATE TABLE `dictionary` (
  `dic_id` int(11) NOT NULL default '0' COMMENT '字典ID',
  `dic_value` varchar(255) default NULL COMMENT '字典名称',
  PRIMARY KEY  (`dic_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Table structure for item
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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Table structure for manager
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
-- Table structure for operate
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
) ENGINE=InnoDB AUTO_INCREMENT=1063 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Table structure for profession
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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Table structure for rate
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
-- Table structure for semester
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
  UNIQUE KEY `se_year_term` (`se_year`,`se_term`,`co_id`),
  KEY `fk_te_ca` (`co_id`),
  CONSTRAINT `fk_se_co` FOREIGN KEY (`co_id`) REFERENCES `college` (`co_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student` (
  `st_id` int(11) NOT NULL auto_increment,
  `us_id` int(11) NOT NULL COMMENT '学号',
  `cl_id` int(11) NOT NULL COMMENT '班级',
  `st_job` varchar(30) default NULL COMMENT '职务',
  `st_part` varchar(30) default NULL COMMENT '党员',
  `st_dormitory` varchar(30) default NULL COMMENT '寝室',
  `st_start_year` int(11) NOT NULL,
  `st_start_term` int(1) NOT NULL,
  `st_end_year` int(11) NOT NULL,
  `st_end_term` int(1) default NULL,
  PRIMARY KEY  (`st_id`),
  KEY `pfk_st_cl` (`cl_id`),
  KEY `fk_st_us` (`us_id`),
  CONSTRAINT `fk_st_cl` FOREIGN KEY (`cl_id`) REFERENCES `class` (`cl_id`),
  CONSTRAINT `fk_st_us` FOREIGN KEY (`us_id`) REFERENCES `user` (`us_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2466 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Table structure for studentoperate
-- ----------------------------
DROP TABLE IF EXISTS `studentoperate`;
CREATE TABLE `studentoperate` (
  `st_id` int(11) NOT NULL,
  `op_id` int(11) NOT NULL default '0',
  PRIMARY KEY  (`op_id`,`st_id`),
  KEY `pfk_so_op` (`op_id`),
  KEY `pfk_so_st` (`st_id`),
  CONSTRAINT `pfk_so_op` FOREIGN KEY (`op_id`) REFERENCES `operate` (`op_id`),
  CONSTRAINT `pfk_so_st` FOREIGN KEY (`st_id`) REFERENCES `student` (`st_id`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Table structure for t_cosler
-- ----------------------------
DROP TABLE IF EXISTS `t_cosler`;
CREATE TABLE `t_cosler` (
  `f_PY` char(1) NOT NULL,
  `cBegin` smallint(5) unsigned NOT NULL,
  `cEnd` smallint(5) unsigned NOT NULL,
  PRIMARY KEY  (`f_PY`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Table structure for user
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
) ENGINE=InnoDB AUTO_INCREMENT=2490 DEFAULT CHARSET=gbk;
